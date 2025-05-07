#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int n , i ;
	float num , sum=0 , average ;
	cout<<"enter number"<<endl;
	cin>>n; // نقوم بادخال عدد الاعداد 
	for(i=1 ; i<=n ; ++i){
		cout<<"enter numbers"<<i<<":"<<endl;
		cin>>num;
		sum+=num;
	}
	average=sum/n;
	cout<<"sum ="<<sum<<endl;
	cout<<"average ="<<average<<endl;
	
}