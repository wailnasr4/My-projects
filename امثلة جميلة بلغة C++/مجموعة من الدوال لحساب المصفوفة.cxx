#include <iostream>
using namespace std;

void readNumber(int &n) {
    cout << "Enter the number: ";
    cin >> n;
}

void readArray(int a[], int n) {
    cout << "Enter the elements of the array: ";
    for (int i = 0; i < n; i++) {
        cin >> a[i];
    }
}

void sortArray(int a[], int n) {
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (a[j] > a[j + 1]) {
                int temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
            }
        }
    }
}

int sumArray(int a[], int n) {
    int sum = 0;
    for (int i = 0; i < n; i++) {
        sum += a[i];
    }
    return sum;
}

double avgArray(int a[], int n) {
    return (double)sumArray(a, n) / n;
}

void printArray(int a[], int n) {
    cout << "The array elements are: ";
    for (int i = 0; i < n; i++) {
        cout << a[i] << " ";
    }
    cout << endl;
}

void evenNumber(int a[], int n) {
    cout << "Even numbers in the array are: ";
    for (int i = 0; i < n; i++) {
        if (a[i] % 2 == 0) {
            cout << a[i] << " ";
        }
    }
    cout << endl;
}

void oddNumber(int a[], int n) {
    cout << "Odd numbers in the array are: ";
    for (int i = 0; i < n; i++) {
        if (a[i] % 2 != 0) {
            cout << a[i] << " ";
        }
    }
     cout<<endl;
}
 
void maxMin(int arr[], int len){
   sort(arr, arr+len);
   cout<<"Maximum element is : "<<arr[len-1]<<endl;
   cout<<"Minimum element is : "<<arr[0]<<endl;

}
 
int main() {

   int size, choice;

   // Input size of the array
   readNumber(size);

   // Declare an array of given size
   int arr[size];

   // Input elements in array
   readArray(arr, size);

   // Sort the array
   sortArray(arr, size);

   // Print the sorted array
   printArray(arr, size);
}