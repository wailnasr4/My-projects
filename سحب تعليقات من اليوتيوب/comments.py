
!pip install selenium
!pip install youtube-comment-downloader
!apt-get update
!apt install chromium-chromedriver
!cp /usr/lib/chromium-browser/chromedriver /usr/bin

import json
from youtube_comment_downloader import YoutubeCommentDownloader
from selenium import webdriver # This line caused the error because 'selenium' wasn't installed.
from selenium.webdriver.common.by import By
from selenium.webdriver.chrome.options import Options
import time

# إعداد YoutubeCommentDownloader  `
downloader = YoutubeCommentDownloader()

# إعداد خيارات متصفح كروم
options = Options()
options.add_argument('--headless') # تشغيل كروم بدون واجهة رسومية
options.add_argument('--no-sandbox')
options.add_argument('--disable-dev-shm-usage')

driver = webdriver.Chrome(options=options)
channel_url = 'https://youtube.com/@aljazeera?si=wOLq_x9HUHcEEwHE/videos'
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
driver.quit()  # إغلاق المتصفح بعد جمع الروابط
# إعداد ملف لتخزين التعليقات
with open("youtube_comment_aljazeera.json", "w", encoding="utf-8") as file:
    all_comments = {}  # قاموس لتخزين التعليقات لكل فيديو
    collected_comments = 0  # عداد التعليقات التي تم جمعها
    max_total_comments = 1000000  # الحد الأقصى لإجمالي عدد التعليقات عبر جميع الفيديوهات

    # جلب التعليقات من كل فيديو
    for video_url in video_urls:
        if collected_comments >= max_total_comments:
            break  # التوقف إذا تم جمع العدد المطلوب من التعليقات

        comments = downloader.get_comments_from_url(video_url)
        video_comments = []

        for comment in comments:
            if collected_comments >= max_total_comments:
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
            collected_comments += 1  # تحديث عداد التعليقات الإجمالية

        all_comments[video_url] = video_comments  # حفظ تعليقات الفيديو في القاموس
    # حفظ جميع التعليقات في ملف JSON
    json.dump(all_comments, file, ensure_ascii=False, indent=4)
print(f"تم جمع وحفظ {collected_comments} تعليقات في الملف youtube_comment_aljazeera.json")
# تحميل ملف التعليقات بعد حفظه
from google.colab import files
files.download('youtube_comment_aljazeera.json')

import pandas as pd
import re
import nltk
from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize
import json

# تحميل موارد NLTK
nltk.download('punkt')
nltk.download('stopwords')

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