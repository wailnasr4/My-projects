#include <iostream>
using namespace std;
int main() {
    int base, exponent;
    long long result = 1;

    cout << "Enter the base number: ";
    cin >> base;

    cout << "Enter the exponent: ";
    cin >> exponent;

    for (int i = 0; i < exponent; ++i) {
        result *= base;
    }

    cout << "Result: " << result << endl;

    return 0;
}