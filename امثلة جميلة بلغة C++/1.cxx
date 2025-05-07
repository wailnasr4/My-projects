#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int n;
	int s=0;
	cout<<"enter number the numbers :";
	cin>>n;
		int *a=new int [n];
		cout<<"enter the numbers : \n";
	for(int i=0 ; i<n ; i++){
	cin>>a[i];
	if(a[i]==5)
	s++;
	delete [] a;
}
	cout<<s;
	
	
}