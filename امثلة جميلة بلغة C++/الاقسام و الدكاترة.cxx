
#include <iostream>
#include <string>

using namespace std;

// تعريف الهيكلة للقسم
struct Department {
    string name;
    int level;
    string* doctors;
};

// دالة لإدخال المواد لكل مستوى
void enterSubjects(string** subjects, int numLevels) {
    for (int i = 0; i < numLevels; i++) {
        int numSubjects;
        cout << "Enter the number of subjects for level " << i + 1 << ": ";
        cin >> numSubjects;

        subjects[i] = new string[numSubjects];

        for (int j = 0; j < numSubjects; j++) {
            cout << "Enter subject " << j + 1 << " for level " << i + 1 << ": ";
            cin >> subjects[i][j];
        }
    }
}

// دالة لإدخال اسم دكتور مشترك في مستويين أو أكثر
void enterSharedDoctor(string** doctors, int numLevels) {
    string doctorName;
    cout << "Enter the shared doctor's name: ";
    cin >> doctorName;

    for (int i = 0; i < numLevels; i++) {
        doctors[i] = new string(doctorName);
    }
}

// دالة لطباعة المتغيرات المشتركة بين مستويين مختلفين
void printSharedVariables(Department* department1, Department* department2) {
    cout << "Shared variables between levels " << department1->level 
         << " and " << department2->level << ":" << endl;

    // طباعة اسماء الدكاترة المشتركة
    cout << "Shared doctors: ";
    
    int size1 = sizeof(department1->doctors) / sizeof(department1->doctors[0]);
    int size2 = sizeof(department2->doctors) / sizeof(department2->doctors[0]);

    for (int i = 0; i < size1 && i < size2; i++) {
        if ((department1->doctors[i]) ==(department2->doctors[i])) {
            cout << (department1->doctors[i]) << ", ";
        }
    }

    cout << endl;
}

int main() {
    
   // تعريف المستوى بشكل عام كمصفوفة من الهيكلات
   Department M[5];

   // إدخال اسماء الأقسام والمستوى وأسماء الدكاترة
   for (int i = 0; i < 5; i++) {
       M[i].name = "Science";
       M[i].level = i + 1;

       M[i].doctors = new string[3];
       for (int j = 0; j < 3; j++) {
           cout << "Enter doctor's name for level :" 
           << M[i].level 
              
                <<" and department "
                <<"Science"
                <<" : ";
           cin >> M[i].doctors[j];
       }
   }

   // إدخال المواد لكل مستوى باستخدام دالة منفصلة
   string** subjects = new string*[5];
   enterSubjects(subjects, 5);
   
  
  
}

