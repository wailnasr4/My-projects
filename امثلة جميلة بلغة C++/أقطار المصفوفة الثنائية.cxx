#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
		int i , j ; 
		int n;
		cout<<"ادخل عدد الاعداد ="; 
		cin>>n;
		int a[n][n];
		for(i=0 ; i<n ; i++)
		for(j=0 ; j<n ; j++){
			cin>>a[i][j];
	}
		for(i=0 ; i<n ; i++){
		for(j=0 ; j<n ; j++){
			cout<<a[i][j]<<" ";
		}cout <<endl;
		}
	
	cout<<"-----------------------------\n";
		cout<<"القطر الرئسي"<<endl;
	for(i=0 ; i<n ; i++)	
		cout<<a[i][i]<<endl;
		cout<<"-----------------------------\n";
		cout<<"القطر الثانوي"<<endl;
		for(i=0 ; i<n ; i++)
		cout<<a[i][n-i-1]<<endl;
		cout<<"-----------------------------\n";
		cout<<"فوق القطر الثانوي"<<endl;
		for(i=0 ; i<n ; i++)
		for(j=0 ; j<n ; j++)
		if(i+j<n-1)
		cout<<a[i][j]<<endl;
		cout<<"-----------------------------\n";
		cout<<"تحت القطر الثانوي"<<endl;	
		for(i=0 ; i<n ; i++)
		for(j=0 ; j<n ; j++)
		if(i+j>=n)
		cout<<a[i][j]<<endl;
		cout<<"-----------------------------\n";
		cout<<"تحت القطر الرئسي"<<endl;
		for(i=0 ; i<n ; i++)
		for(j=0 ; j<n ; j++)
		if(i>j)
		cout<<a[i][j]<<endl;
		cout<<"-----------------------------\n";
		cout<<"فوق القطر الرئسي"<<endl;
		for(i=0 ; i<n ; i++)
		for(j=0 ; j<n ; j++)
		if(i<j)
		cout<<a[i][j]<<endl;
		cout<<"-----------------------------\n";
		
		
}