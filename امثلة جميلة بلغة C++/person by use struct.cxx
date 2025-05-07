#include <iostream>
using namespace std;

struct Person {
    string name;
    int age;
    float length;
};

int main() {
    int n;
    cout << "Enter the number of persons: ";
    cin >> n;

    Person* persons = new Person[n];

    for (int i = 0; i < n; i++) {
        cout << "Enter name of person " << i+1 << ": ";
        cin >> persons[i].name;
        cout << "Enter age of person " << i+1 << ": ";
        cin >> persons[i].age;
        cout<<"Enter length of person"<<i+1<<":";
        cin>>persons[i].length;
    }

    cout << "\nPersons entered:\n";
    for (int i = 0; i < n; i++) {
        cout << "Person " << i+1 << ": Name - " << persons[i].name << ", Age - " << persons[i].age << ",length-"<<persons[i].length<<endl;
    }

    delete[] persons;

    return 0;
}
