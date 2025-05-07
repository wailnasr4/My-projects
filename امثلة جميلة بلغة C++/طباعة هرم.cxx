#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int i , j , x;
	int rows;
	cin>>rows;
	for(i=1 ; i<=rows ; i++){
		for(x=0 ; x<rows-i ; x++)
		cout<<" ";
		for(x=0 ; x<i*2-1 ; x++)
		cout<<"*";
		cout<<endl;
	}
		
	
}