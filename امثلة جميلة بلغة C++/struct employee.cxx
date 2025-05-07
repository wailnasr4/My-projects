#include <iostream>
#include <fstream>
#include <string.h>
using namespace std;
struct personid{
    int code;
    string sex;
    int date;
    void input(){
        cout<<"Enter ID number :\n";
        cin>>code;
        cout<<"Enter sex :\n";
        cin>>sex;
        cout<<"Enter the date of birth :\n";
        cin>>date;
    }
    void print(){
        cout<<"ID : "<<code<<endl;
        cout<<"Sex : "<<sex<<endl;
        cout<<"Date : "<<date<<endl;
    }
};
struct emp{
static int num;
string name;
int sal;
personid id;
void set(string n)
{name=n;}
void printinfo(){
    cout<<"\nNumber of emp : "<<num<<endl;
    cout<<"Name : "<<name<<endl;
    num++;
}
    
};
int emp::num=1;
int main(){
    int n;
    cout<<"Enter the size :\n";
    cin>>n;
    emp p[n];
        for(int i=0;i<n;i++){
        string name;
        int sal;
        cout<<"Enter name :\n";
        cin>>name;
        p[i].set(name);
        cout<<"Enter sal :\n";
        cin>>sal;
        p[i].sal=sal;
        p[i].id.input();
        }
       
            for(int i=0;i<n;i++){
            p[i].printinfo();
            p[i].id.print();}
}