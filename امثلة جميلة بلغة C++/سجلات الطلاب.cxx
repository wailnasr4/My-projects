#include <iostream>
using namespace std;

struct Name {
    string firstName;
    string middleName;
    string lastName;
};

struct Address {
    string country;
    string city;
    string street;
};

struct DateOfBirth {
    int day;
    int month;
    int year;
};

struct Record {
    Name name;
    Address address;
    DateOfBirth dob;
};

void fillRecord(Record* record) {
    cout << "Enter first name: ";
    cin>> record->name.firstName;

    cout << "Enter middle name: ";
    cin >> record->name.middleName;

    cout << "Enter last name: ";
    cin >> record->name.lastName;

    cout << "Enter country: ";
    cin >> record->address.country;

    cout << "Enter city: ";
    cin >> record->address.city;

    cout << "Enter street: ";
    cin >> record->address.street;

    cout << "Enter day of birth: ";
    cin >> record->dob.day;

     cout << "Enter month of birth: ";
     cin >> record->dob.month;

     cout << "Enter year of birth: ";
     cin >> record->dob.year;
}

void displayRecord(const Record* record) {
     cout << " Name: " << record->name.firstName <<  " " << record->name.middleName << " " << record->name.lastName << endl;

     cout << " address: " << record->address.country<<" _ "<<record -> address.city<<" _ "<<record -> address.street<<endl; 

      cout <<" Date of Birth : "<<record -> dob.year<<" / "<<record -> dob.month<<" / "<<record -> dob.day <<endl;
}

int main() {
   int numRecords = 0;

   // Prompt user for number of records
   do {
       cout<<"How many records do you want to create? (must be a positive integer): ";
       cin>>numRecords;
   } while (numRecords <= 0);

   // Create an array of records
   Record* records = new Record[numRecords];

   // Fill and display each record
   for (int i = 0; i < numRecords; i++) {
       fillRecord(&records[i]);
       displayRecord(&records[i]);
       delete &records[i];
   }

   // Deallocate memory
   delete[] records;

   return 0;
}

