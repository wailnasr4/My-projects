#include <iostream>
using namespace std;

// تعريف المصفوفة للصورة
int image[8][8] = {
    {25, 25, 25, 25, 25, 25, 25, 25},
    {25, 25, 25, 25, 25, 25, 25, 25},
    {25, 25, 25, 25, 25, 25, 25, 25},
    {25, 25, 25, 25, 25, 25, 25, 25},
    {25, 25, 25, 25, 25, 25, 25, 25},
    {25, 25, 25, 25, 25, 25, 25, 25},
    {25, 25, 25, 25, 25, 25, 25, 25},
    {25, 25, 25, 25, 25, 25, 25, 25}
};

int main() {
    for(int i=0 ; i<8 ; i++){
       for(int j=0 ; j<8 ; j++){
    	  cout<< image[i][j]<<" ";
       }cout<<endl;
    }
    
    // زيادة دقة الصورة
    cout<<"\nIncrease image resolution : \n";
    for (int i = 0; i < 8; i++) {
        for (int j = 0; j < 8; j++) {
            image[i][j] *= 2;
            cout<<image[i][j]<<" ";
        }cout<<endl;
    }

    // حذف أربع صفوف متتالية
    for (int i =0; i < 4; i++) {
        for (int j = 0; j < 8; j++) {
            image[i][j] = 0;
        }
    }

    // طباعة الصورة بعد التعديلات
    cout << "Image after modifications:" << endl;
    for (int i = 0; i < 8; i++) {
        for (int j = 0; j < 8; j++) {
            cout << image[i][j] << " ";
        }
        cout << endl;
    }

  //اظهار  عناصر القطر الرئسي و الثانوي
    cout << "Main diagonal: ";
    for (int i = 0; i < 8; i++) {
        cout << image[i][i] << " ";
    }
    cout << endl;

    cout << "Secondary diagonal: ";
    for (int i = 0; i < 8; i++) {
        cout << image[i][7 - i] << " ";
    }
    cout << endl;

    // اظهار مساحة الذاكرة الشاغرة برمجيًا
    int freeMemory = sizeof(image);
    cout << "Free memory space: " << freeMemory << " bytes" << endl;

    return 0;
}