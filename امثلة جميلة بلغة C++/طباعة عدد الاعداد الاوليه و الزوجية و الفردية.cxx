#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int n;
	int i , x , s , y , prim , odd , even;
	prim=0 ; even=0 ; odd=0; s=0;
	cout<<"ادخل عدد الاعداد =";
	cin>>n;
	int a[n];
	for(i=0 ; i<n ; i++){
	cin>>a[i];
	}
	for(i=0 ; i<n ; i++){
		x=a[i];  s=0;
		for(y=1 ; y<=x ; y++)
		if(x%y==0)
		s++;
		if(s==2)
		a[i]=x;
	}	for(i=0 ; i<n ; i++){
		prim++;
      }for(i=0 ; i<n ; i++){
		if(a[i]%2==0){
			even++;
		}}
		for(i=0 ; i<n ; i++){
			if(a[i]%2==1){
				odd++;
			}}
			cout<<"prim ="<<prim<<endl;
			cout<<"even ="<<even<<endl;
			cout<<"odd ="<<odd<<endl;
		

}