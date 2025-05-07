#include <iostream>
#include <fstream>
#include <string>

void SetMyString(std::string content) {
    
    std::ofstream file("input.txt");
    if (file.is_open()) {
          std::cout << "Enter text (enter 0 to stop):\n ";
        while (true) {
          
            std::getline(std::cin, content);
            if (content == "0") {
                break;
            }
            file << content << std::endl;
        }
        file.close();
    } else {
        std::cout << "Unable to create file";
    }
}

void CreateFile(const std::string& filename, const std::string& content) {
    std::ofstream file(filename);
    if (file.is_open()) {
        file << content;
        file.close();
    } else {
        std::cerr << "Unable to create file";
    }
}

void WriteInFile(const std::string& filename, const std::string& content, int line) {
    std::ifstream fin(filename);
    std::string fileContent, temp;
    int currentLine = 1;
    while (std::getline(fin, temp)) {
        if (currentLine == line) {
            fileContent += content + "\n";
        }
        fileContent += temp + "\n";
        currentLine++;
    }
    fin.close();
    std::ofstream fout(filename);
    fout << fileContent;
    fout.close();
}

int main() {
    std::string x;
    SetMyString(x);
    CreateFile("output.txt", "This is a new file.\n");
    WriteInFile("output.txt", "Inserted text", 2);
    return 0;
}