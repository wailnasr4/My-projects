#include <iostream>
using namespace std;

int main() {
    int matrix[3][3];
    int result[3]={1,1,1} ;

    // ادخال قيم المصفوفة
    cout << "أدخل قيم المصفوفة الثنائية البعد بحجم 3*3:" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cin >> matrix[i][j];
        }
    }

    // حساب حاصل الضرب لكل عمود
    for (int j = 0; j < 3; j++) {
        for (int i = 0; i < 3; i++) {
            result[j] *= matrix[i][j];
        }
    }

    // طباعة المصفوفة الثنائية البعد
    cout << "المصفوفة الثنائية البعد:" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << matrix[i][j] << " ";
        }
        cout << endl;
    }

    // طباعة المصفوفة الأحادية
    cout << "المصفوفة الأحادية:" << endl;
    for (int i = 0; i < 3; i++) {
        cout << result[i] << " ";
    }
    
    return 0;
}