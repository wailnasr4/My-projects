#include<iostream>
using namespace std;
int prim(int n)
{
	int i , s=0;
	for(i=1 ; i<=n ; i++)
	if(n%i==0)
	s++;
	if(s==2)
	cout<<"is prim"<<endl;
	else 
	cout<<"is not prim"<<endl;
}
	
int main(int argc, char *argv[])
{
	for(;;){
	int x;
	cin>>x;
	prim(x);
	
}}