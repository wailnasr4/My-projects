#include <iostream>
using namespace std;

int main() {
    for(;;){
    int n;
    cout << "\nEnter the number of elements: ";
    cin >> n;

    int arr[n];
    cout << "Enter the elements: "<<endl;
    for (int i = 0; i < n; i++) {
        cin >> arr[i];
    }

    // ترتيب العناصر تصاعديًا
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }

    cout << "Ascending order: ";
    for (int i = 0; i < n; i++) {
        cout << arr[i] << " ";
    }
    
    // ترتيب العناصر تنازليًا
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] < arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }

    cout << "\nDescending order: ";
    for (int i = 0; i < n; i++) {
        cout << arr[i] << " ";
    }}

    return 0;
}