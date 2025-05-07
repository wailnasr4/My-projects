#include<iostream>
#include<fstream>
#include<string>
using namespace std;
int main(int argc, char *argv[])
{
	ofstream myfile;
	
	myfile.open("input.txt",ios::app);
	myfile<<"wail ali ahmed nasr";
	myfile.close();
	
		cout<<sizeof(myfile);
}