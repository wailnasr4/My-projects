#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int i , j ;
	for(i=1 ; i<=5 ; i++){
	for(j=5 ; j>=i ; j--)
	cout<<"*";
	cout<<"\n";
}}