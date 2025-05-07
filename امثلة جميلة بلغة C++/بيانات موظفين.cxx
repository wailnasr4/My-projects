#include <iostream>
#include <string>
using namespace std;

struct Employee {
    string name;
    int id;
};
struct ExecutiveManager {
    Employee employee;
};
struct Secretary {
    Employee employee;
    void requestVacation(Employee& employee, ExecutiveManager& manager) {
        cin>>
        manager +=manager.employee;
        
        // Submit vacation request to the manager
        // ...
    }
    void requestMoney(Employee& employee, ExecutiveManager& manager, double amount) {
        manager+=manager.employee;
        // Submit money request to the manager
        // ...
    }
};



int main() {
    Secretary secretary;
    ExecutiveManager manager;

    // Employee requests vacation through the secretary
    Employee emp1 = {"John", 1};
    secretary.requestVacation(emp1, manager);

    // Employee requests money through the secretary
    Employee emp2 = {"Alice", 2};
    double amount = 1000.0;
    secretary.requestMoney(emp2, manager, amount);

    return 0;
}

