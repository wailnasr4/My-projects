#include <iostream>
#include <fstream>
using namespace std;
int main() {
    // فتح الملف للكتابة
    ofstream file("numbers.txt");

    // التأكد من أن الملف تم فتحه بنجاح
    if (!file.is_open()) {
        cout << "لا يمكن فتح الملف!" <<endl;
        return 1;
    }

    // قراءة الأرقام من المستخدم وكتابتها في الملف
    int n;
    cout<<"enter the numper of numpers : ";
    cin>>n;
    int number;
    for (int i = 0; i < n; ++i) {
        cout << "أدخل الرقم " << i + 1 << ": ";
        cin >> number;
        file << number << endl;
    }

    // إغلاق الملف بعد الانتهاء من الكتابة فيه
    file.close();

    // فتح الملف للقراءة
    ifstream readFile("numbers.txt");

    // التأكد من أن الملف تم فتحه بنجاح
    if (!readFile.is_open()) {
        cout << "لا يمكن فتح الملف!" << endl;
        return 1;
    }

    int sum = 0;
    
    // قراءة الأرقام من الملف وحساب المجموع
    while (readFile >> number) {
        sum += number;
    }

   // إغلاق الملف بعد الانتهاء من القراءة منه
   readFile.close();

   float average = (sum) / n;

   // طباعة نتائج البرنامج
   cout << "المجموع: " << sum << endl;
   cout << "المتوسط:"<< average << endl;

   return 0;
}