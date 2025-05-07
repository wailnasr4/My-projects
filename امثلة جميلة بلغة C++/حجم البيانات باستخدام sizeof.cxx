
#include <iostream>
using namespace std;

struct person {
    string name;
    int age;
};

int main() {
    char ch;
    int* n;
    float f[1];
    person p;
    person y[1];
    person* x;

    cout << "Size of char: " << sizeof(ch) << " bytes" << endl;
    cout << "Size of int*: " << sizeof(n) << " bytes" << endl;
    cout << "Size of float[]: " << sizeof(f) << " bytes" << endl;
    cout << "Size of person: " << sizeof(p) << " bytes" << endl;
    cout << "Size of person[]: " << sizeof(y) << " bytes" << endl;
    cout << "Size of person*: " << sizeof(x) << " bytes"<<endl;

}
