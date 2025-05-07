#include <iostream>

struct MyStruct {
    private:
    int x;
    int y;
public:
    void readX() {
        std::cout << "Enter the value of x: ";
        std::cin >> x;
    }

    void readY() {
        std::cout << "Enter the value of y: ";
        std::cin >> y;
    }

    void readXY() {
        readX();
        readY();
    }

    void printX() {
        std::cout << "x = " << x << std::endl;
    }

    void printY() {
        std::cout << "y = " << y << std::endl;
    }

    void printXY() {
        printX();
        printY();
    }
};

int main() {
    MyStruct myStruct;

    myStruct.readXY();
    
    myStruct.printXY();

    return 0;
}