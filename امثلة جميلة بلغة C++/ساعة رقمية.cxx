#include<iostream>
#include<windows.h>
using namespace std;
int main(int argc, char *argv[])
{
	int hrs,min,sec;
	cout<<"hours ";
	cin>>hrs;
	cout<<"minutes ";
	cin>>min;
	cout<<"seconds ";
	cin>>sec;
	while(1){
		system("cls");
		if(sec>59){
			min++;
			sec=0;
		}if(min>59){
			hrs++;
			min=0;
		}if(hrs>23)
		hrs=0;
		cout<<hrs<<":"<<min<<":"<<sec<<endl;
		sec++;
		sleep(1);
		
	}
	
}