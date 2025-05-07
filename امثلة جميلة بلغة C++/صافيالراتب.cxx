#include<iostream>
using namespace std;
void sum(float x,float y){
	cout<<"ادخل الراتب :";
	cin>>x;
	cout<<"ادخل الضريبة :";
	cin>>y;
	
	cout<<"صافي الراتب ="<<x-y<<endl;
}
int main(int argc, char *argv[])
{
	float a,b;
	
	sum(a,b);
	
}