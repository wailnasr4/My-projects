#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int n,i,s;
	cin>>n;
	s=0;
	for(i=1;i<=n;i++)
	if(n%i==0)
	s=s+1;
	if(s==2)
	cout<<"primary"<<endl;
	else
	cout<<"not primary"<<endl;
}