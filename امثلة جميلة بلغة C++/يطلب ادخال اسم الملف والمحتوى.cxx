#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main() {
    string fileName, fileContent;

    // Ask user to enter file name
    cout << "Enter the file name: ";
    cin >> fileName;

    // Ask user to enter file content
    cout << "Enter the file content (enter 0 to stop):" << endl;
    while (cin >> fileContent) {
        // Append the entered content to the fileContent string
        if(fileContent=="0"){
        	break;
        }
        fileContent += "\n";
    }

    // Create a new file with the entered name and write the content to it
    ofstream outputFile(fileName);
    if (outputFile.is_open()) {
        outputFile << fileContent;
        outputFile.close();
        cout << "File saved successfully." << endl;
    } else {
        cerr << "Error: Unable to create or open the file." <<endl;
        return 1;
    }

    return 0;
}
