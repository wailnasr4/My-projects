#include <iostream>
#include <fstream>
#include <string>
using namespace std;

void SetMyString(string& content) {
    string input;
    cout << "Enter text (enter 0 to stop): ";
    while (true) {
        getline(cin, input);
        if (input == "0") {
            break;
        }
        content += input + "\n";
    }
}

void CreateFile(const string& filename, const string& content) {
    ofstream file(filename);
    if (file.is_open()) {
        file << content;
        file.close();
    } else {
        std::cerr << "Unable to create file";
    }
}

void WriteInFile(const string& filename, const string& content, int line)
 {
    ifstream fin(filename);
    string fileContent, temp;
    int currentLine = 1;
    while (getline(fin, temp)) {
        if (currentLine == line) {
            fileContent += content + "\n";
        }
        fileContent += temp + "\n";
        currentLine++;
    }
    fin.close();
    ofstream fout(filename);
    fout << fileContent;
    fout.close();
}

int main() {
    string FilePath, FileContent;
    int LineNumber;
    cout << "Enter file name: ";
    cin >> FilePath;
    SetMyString(FileContent);
    CreateFile(FilePath, FileContent);
    cout << "Enter line number: ";
    cin >> LineNumber;
    WriteInFile(FilePath, FileContent, LineNumber);
    return 0;
}