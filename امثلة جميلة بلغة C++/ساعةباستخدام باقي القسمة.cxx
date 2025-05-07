
#include <iostream>
using namespace std;

void printTime(int seconds) {
    int hours = seconds / 3600;
    int minutes = (seconds % 3600) / 60;
    int remainingSeconds = seconds % 60;

    cout << "Time: " << hours << " hours, " << minutes << " minutes, " << remainingSeconds << " seconds" << endl;
}

void printHours(int seconds) {
    int hours = seconds / 3600;
    cout << "Hours: " << hours << endl;
}

void printMinutes(int seconds) {
    int minutes = (seconds % 3600) / 60;
    cout << "Minutes: " << minutes << endl;
}

void printRemainingSeconds(int seconds) {
    int remainingSeconds = seconds % 60;
    cout << "Remaining Seconds: " << remainingSeconds << endl;
}

int main() {
    int inputSeconds;
    
    cout << "Enter the number of seconds: ";
    cin >> inputSeconds;

    printTime(inputSeconds);
    printHours(inputSeconds);
    printMinutes(inputSeconds);
    printRemainingSeconds(inputSeconds);

    return 0;
}

