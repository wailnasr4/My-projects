
!pip install selenium
!pip install youtube-comment-downloader
!apt-get update
!apt install chromium-chromedriver
!cp /usr/lib/chromium-browser/chromedriver /usr/bin


import json
from youtube_comment_downloader import YoutubeCommentDownloader
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.chrome.options import Options
from multiprocessing import Value
import time
import threading
# إعداد YoutubeCommentDownloader  `
downloader = YoutubeCommentDownloader()

# إعداد خيارات متصفح كروم
options = Options()
options.add_argument('--headless') # تشغيل كروم بدون واجهة رسومية
options.add_argument('--no-sandbox')
options.add_argument('--disable-dev-shm-usage')

collected_comments=Value('i',0)
all_comments={}
max_total_comments=1000000
def fetch_video_urls(channel_url):

   driver = webdriver.Chrome(options=options)
   
# فتح صفحة الفيديوهات الخاصة بالقناة
   driver.get(channel_url)
   time.sleep(5)  # انتظار تحميل الصفحة

   scroll_pause_time = 1  # مدة التوقف بين كل عملية تمرير
   last_height = driver.execute_script("return document.documentElement.scrollHeight")
   video_urls = []  # قائمة لحفظ روابط الفيديوهات
# جمع روابط الفيديوهات
   while True:
       videos = driver.find_elements(By.XPATH, '//*[@id="video-title"]')
       for video in videos:
           video_url = video.get_attribute('href')
           if video_url and video_url not in video_urls:
               video_urls.append(video_url)
       driver.execute_script("window.scrollTo(0, document.documentElement.scrollHeight);")
       time.sleep(scroll_pause_time)
       new_height = driver.execute_script("return document.documentElement.scrollHeight")
       if new_height == last_height:
           break
       last_height = new_height
   driver.quit()  # إغلاق المتصفح بعد جمع الرواب
   return video_urls


# تقسيم روابط الفيديو إلى مجموعات لتوزيع عملية الجمع
def fetch_comments(video_urls, all_comments, collected_comments,max_total_comments):
    
    
# جلب التعليقات من كل فيديو
    for video_url in video_urls:
       if collected_comments.value >= max_total_comments:
        break
       comments = downloader.get_comments_from_url(video_url)
       video_comments=[]
       for comment in comments:
            if collected_comments.value >= max_total_comments:
                break  # التوقف إذا تم جمع العدد المطلوب من التعليقات

            author = comment.get('author', 'معلق غير معروف')
            text = comment.get('text', '')
            published_at = comment.get('time', 'غير متوفر')

            # إعداد التعليق
            comment_info = {
                "author": author,
                "text": text,
                "published_at": published_at,
                "replies": []  # قائمة الردود
            }

            # التحقق من وجود ردود على التعليق
            if 'replies' in comment and isinstance(comment['replies'], list):
                for reply in comment['replies']:
                    if isinstance(reply, dict):
                        reply_author = reply.get('author', 'معلق غير معروف')
                        reply_text = reply.get('text', '')
                        reply_published_at = reply.get('time', 'غير متوفر')

                        # إعداد الرد وإضافته إلى قائمة الردود
                        reply_info = {
                            "author": reply_author,
                            "text": reply_text,
                            "published_at": reply_published_at
                        }
                        comment_info['replies'].append(reply_info)  # إضافة الرد إلى التعليق

            # إضافة التعليق مع الردود إلى قائمة تعليقات الفيديو
            video_comments.append(comment_info)
            with collected_comments.get_lock():
               collected_comments.value +=1
       with collected_comments.get_lock():   # تحديث عداد التعليقات الإجمالية
          all_comments[video_url] = video_comments  # حفظ تعليقات الفيديو في القاموس
    print(f"تم جمع وحفظ {collected_comments.value} تعليق في الملف youtube_comment_aljazeera.json")
# اعداد ملفات التخزين
channel_urls = ['https://youtube.com/@aljazeera?si=wOLq_x9HUHcEEwHE/videos',
               'https://youtube.com/@alarabytv_news?si=WS9KEDCWsleQLPve']


threads=[]

for channel_url in channel_urls:
  video_urls=fetch_video_urls(channel_url)
  video_urls_chunks=[video_urls[i:i+10]for i in range(0,len(video_urls),10)]
  for chunk in video_urls_chunks:
    thread=threading.Thread(target=fetch_comments,args=(chunk,all_comments,collected_comments,max_total_comments))
    threads.append(thread)
    thread.start()

for thread in threads:
    thread.join()



# حفظ جميع التعليقات في ملف JSON
with open("youtube_comment_aljazeera.json","w",encoding="utf-8") as file:
    json.dump(all_comments, file, ensure_ascii=False, indent=4)

# تحميل ملف التعليقات بعد حفظه
from google.colab import files
files.download('youtube_comment_aljazeera.json')

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

import pandas as pd
import re
import nltk
from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize

# تحميل موارد NLTK
nltk.download('punkt_tab')
nltk.download('averaged_perceptron_tagger')
nltk.download('stopwords')
nltk.download('wordnet')

# قراءة ملف JSON مع تحديد ترميز UTF-8
with open('youtube_comment_aljazeera.json', 'r', encoding='utf-8') as f:
    data = json.load(f)

# Create a list to store the comment data
comments_data = []

# Iterate through the video URLs and their comments
for video_url, comments in data.items():
    for comment in comments:
        comment_text = comment.get('text', '')  # Extract the comment text
        comments_data.append({'video_url': video_url, 'comment': comment_text})

# Create the DataFrame
df = pd.DataFrame(comments_data)

# دالة لتنظيف النص
def clean_text(text):
    # Check if the input is a string
    if isinstance(text, str):
        # الاحتفاظ فقط بالحروف العربية والإنجليزية
        cleaned_text = re.sub(r'[^a-zA-Z\u0600-\u06FF\s]+', '', text)
        cleaned_text = re.sub(r'http\S+|www\S+', '', text)
    # إزالة الإيموجيات
        cleaned_text = re.sub(r'[^\w\s,]', '', text)
    # إزالة الأرقام
        text = re.sub(r'\d+', '', text)


        # تحويل النص إلى tokens
        tokens = word_tokenize(cleaned_text)

        # إزالة stop words
        stop_words = set(stopwords.words('arabic') + stopwords.words('english'))
        filtered_tokens = [token for token in tokens if token.lower() not in stop_words]

        return filtered_tokens
    else:
        # Handle non-string values by returning an empty list
        return []

# تطبيق دالة التنظيف على عمود التعليقات
df['comment'] = df['comment'].apply(clean_text)

# حفظ إطار البيانات المعدل في ملف JSON جديد
df.to_json('youtube_comments.json', orient='records', force_ascii=False, indent=4)

# عرض إطار البيانات بعد التنظيف
print(df)
from google.colab import files
files.download('youtube_comments.json')