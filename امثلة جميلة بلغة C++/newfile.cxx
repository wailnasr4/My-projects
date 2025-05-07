
#include <iostream>
#include <string>

using namespace std;

// تعريف الهيكلة للقسم
struct Department {
    string name;
    int* level;
    string* doctors;
};

// دالة لإدخال المواد لكل مستوى
void enterSubjects(Department* department, int numSubjects) {
     level.level
    for (int i = 0; i < numSubjects; i++) {
        cout << "Enter subject " << i + 1 << ": ";
        cin >> department->level[i];
    }
}

// دالة لإدخال اسم دكتور مشترك في مستويين أو أكثر
void enterSharedDoctor(Department* department1, Department* department2, string doctorName) {
    for (int i = 0; i < department1->doctors; i++) {
        if (department1->doctors[i] == doctorName) {
            for (int j = 0; j < department2->numDoctors; j++) {
                if (department2->doctors[j] == doctorName) {
                    return;
                }
            }
            department2->doctors[department2->numDoctors] = doctorName;
            department2->numDoctors++;
            return;
        }
    }
}

// دالة لطباعة المتغيرات المشتركة بين مستويين مختلفين
void printSharedVariables(Department* department1, Department* department2) {
    cout << "Shared doctors between " << department1->name << " and " << department2->name << ":" << endl;
    
    for (int i = 0; i < department1->numDoctors; i++) {
        for (int j = 0; j < department2->numDoctors; j++) {
            if (department1->doctors[i] == department2->doctors[j]) {
                cout << "- " << department1->doctors[i] << endl;
                break;
            }
        }
    }
}

int main() {
    // تعريف المتغيرات المشتركة بين جميع المستويات
    string sharedDoctors[5];
    
    // تعريف قسم العلوم وإضافة اسماء الدكاترة
    Department science;
    
    science.name = "Science";
    science.level = 5;
    
    science.doctors = sharedDoctors;
    
    // إضافة اسماء الدكاترة في قسم العلوم
    cout << "Enter the names of doctors in the Science Department:" << endl;
    
    for (int i = 0; i < science.level; i++) {
        cout << "Doctor " << i + 1 << ": ";
        cin >> science.doctors[i];
        
        // زيادة عدد الأطباء في قسم العلوم
        science.numDoctors++;
        
        // إضافة اسماء الأطباء إلى المصفوفة المشتركة بجميع المستويات
        sharedDoctors[i] = science.doctors[i];
        
        // طباعة اسماء الأطباء في قسم العلوم حتى هذه النقطة فقط
        cout <<

    }