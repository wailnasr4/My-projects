#include<iostream>
using namespace std;
int fact(int n)
{
   if(n==1){
   return 1;
   }else if (n>1){
   	return n*fact(n-1);
   }
}
int main()
{
	for(;;){
	int i;
	cin>>i;
	cout<<fact(i)<<endl;
}}
	