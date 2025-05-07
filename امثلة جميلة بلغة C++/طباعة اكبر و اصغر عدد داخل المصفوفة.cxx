#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int n , i , max;
	cout<<"ادخل عدد الاعداد ";
	cin>>n;
	int a[n];
	for(i=0 ; i<n ; i++)
	cin>>a[i];
	max=a[0];
	for(i=1 ; i<n ; i++)
	if(a[i]>max)
	max=a[i];
	cout<<"max ="<<max<<endl;
int	min=a[0];
for(i=1 ; i<n ; i++)
	if(a[i]<min)
	min=a[i];
	cout<<"min ="<<min<<endl;
}