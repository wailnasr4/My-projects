#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int i , j;
	j=1;
	for(i=1;i<=12;i++){
		cout<<j<<"*"<<i<<"="<<j*i<<endl;
		if(i>=12 && j<12){
			cout<<"\n";
			i=1;
			j++;
		}}
}