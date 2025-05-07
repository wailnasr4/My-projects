
#include <iostream>
#include <string>
using namespace std;

const int MAX_DOCTORS = 5; // الحد الأقصى لعدد الأطباء في القسم

struct Level {
    string name;
    string doctors[MAX_DOCTORS];
};

struct Department {
    string name;
    Level levels[3]; // يحتوي على 3 مستويات
};

void enterSubjects(Level& level) {
    cout << "Enter subjects for level " << level.name << ":" << endl;
    // قم بإضافة رمز لإدخال المواد لكل مستوى هنا
}

void enterSharedDoctors(Department& department, int levelIndex) {
    cout << "Enter shared doctors for level " << department.levels[levelIndex].name << ":" << endl;
    // قم بإضافة رمز لإدخال أسماء الأطباء المشتركين في المستوى هنا
}

void printSharedDoctors(Department& department, int levelIndex1, int levelIndex2) {
    cout << "Shared doctors between level " << department.levels[levelIndex1].name 
         << " and level " << department.levels[levelIndex2].name 
         << ":" << endl;
    
    for (int i = 0; i < MAX_DOCTORS; i++) {
        if (department.levels[levelIndex1].doctors[i] != "" && 
            department.levels[levelIndex2].doctors[i] != "") {
            cout << department.levels[levelIndex1].doctors[i] << endl;
        }
    }
}

int main() {
    Department department;

    // إدخال اسم القسم
    cout << "Enter department name: ";
    getline(cin, department.name);

    // إدخال اسماء المستويات والأطباء المشتركين في كل مستوى
    for (int i = 0; i < 3; i++) {
        cout << "Enter name of level " << i + 1<< ": ";
        getline(cin, department.levels[i].name);
        
        enterSharedDoctors(department, i);
        
        enterSubjects(department.levels[i]);
        
        cout<<endl;
        
    }