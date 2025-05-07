
#include <iostream>
using namespace std;

int main() {
    char str[100];
    int length = 0;

    cout << "Enter a string: ";
    cin>>str;

    // حساب طول المصفوفة النصية
    while (str[length] != '\0') {
        length++;
    }

    cout << "Length of the string: " << length << endl;

    return 0;
}