#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int n , i , max2,max1,min1,min2;
	cout<<"ادخل عدد الاعداد =";
	cin>>n;
	int a[n];
	for(i=0;i<n;i++)
	cin>>a[i];
	min1=a[0];
	min2=min1;
	for(i=0;i<n;i++)
	if(min1>a[i]){
	min2=min1;
	min1=a[i];
	}else if(min2>a[i]){
	min2=a[i];
	}cout<<"min1 ="<<min1<<endl;
      cout<<"min2 ="<<min2<<endl;
      cout<<min2-min1<<endl;
      
	for(i=0;i<n;i++)
	max1=a[0];
	max2=max1;
	for(i=0;i<n;i++)
	if(max1<a[i]){
	max2=max1;
	max1=a[i];
	}else if(max2<a[i]){
	max2=a[i];
	}cout<<"max1 ="<<max1<<endl;
      cout<<"max2 ="<<max2<<endl;
      cout<<max1-max2<<endl;
}