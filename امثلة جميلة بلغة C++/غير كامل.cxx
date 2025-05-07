#include<iostream>
using namespace std;
struct Employees{
	int id;
	string name;
};
struct Secrter{
	Employees employee;
	void recess(){
		
	}
	void monue(){
		
	}
};
struct Manager{
	Secrter  secrter;
	bool Assent(Secrter  secrter){
		recess();
		return true;
	}
};
int main(int argc, char *argv[])
{
	int n;
	Manager manager;
	cin>>n;
	Secrter secrter[n];
	for(int i=0 ; i<n ; i++){
		string name;
		int id;
	cin>>id;
	secrter[i].employee;
	cin>>name;
	secrter[i].employee;}
}