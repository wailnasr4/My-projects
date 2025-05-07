#include <iostream>
using namespace std;

int main() {
    int matrix[3][3];
    int evenNumbers[9];
    int oddNumbers[9];
    int evenIndex = 0;
    int oddIndex = 0;

    // إدخال قيم المصفوفة
    cout << "أدخل قيم المصفوفة الثنائية البعد (3*3):" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cin >> matrix[i][j];
            if (matrix[i][j] % 2 == 0) {
                evenNumbers[evenIndex] = matrix[i][j];
                evenIndex++;
            } else {
                oddNumbers[oddIndex] = matrix[i][j];
                oddIndex++;
            }
        }
    }

    // طباعة المصفوفة الأصلية
    cout << "المصفوفة الثنائية البعد:" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << matrix[i][j] << " ";
        }
        cout << endl;
    }

    // طباعة المصفوفة الأحادية للأعداد الزوجية
    cout << "الأعداد الزوجية في المصفوفة الأحادية:" << endl;
    for (int i = 0; i < evenIndex; i++) {
        cout << evenNumbers[i] << " ";
    }
    cout << endl;

    // طباعة المصفوفة الأحادية للأعداد الفردية
    cout << "الأعداد الفردية في المصفوفة الأحادية:" << endl;
    for (int i = 0; i < oddIndex; i++) {
        cout << oddNumbers[i] << " ";
    }
    cout << endl;

    return 0;
}