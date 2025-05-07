#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
		int n , i , s ;
	cin>>n;
	for(i=1 ; i<n ; i++)
	if(n%i==0)
	s+=i;
	if(s==n){
	cout<<"Complete"<<endl;
}	else
     cout<<"not Complete"<<endl;
	
}