#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{	
	int n;
	int i , j , f , x ;
	cout<<" ادخل عدد الاعداد =";
	cin>>n;
	int a[n];
	for(i=0 ; i<n ; i++)
		cin>>a[i];
	for(i=0 ; i<n ;i++){
		x=a[i];    f=1;
		for(j=1 ; j<=x ; j++)
		f*=j;
		a[i]=f;
	}for(i=0 ; i<n ; i++)
	cout<<" "<<a[i]<<endl;
}