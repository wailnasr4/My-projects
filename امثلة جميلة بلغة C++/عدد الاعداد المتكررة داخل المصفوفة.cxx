#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int n;
	int v , i , s=0;
	cout<<"ادخل عدد الاعداد =";
	cin>>n;
	int a[n];
	for(i=0 ; i<n ; i++){
	cin>>a[i];
	}cout<<"enter v =";
	cin>>v;
	for(i=0 ; i<n ; i++){
     if(a[i]==v){
		s++;
	}
	}for(i=0 ; i<n ;i++){
    } cout<<s;
     
}