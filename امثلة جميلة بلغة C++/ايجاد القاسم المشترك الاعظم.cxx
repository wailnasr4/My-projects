#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int x , y , i , g ;
	cin>>x>>y;
	if(x<y){
		g=x;
	}else{
		g=y;
	}
	for(i=g ; i>=1 ; i--)
	if(x%i==0 && y%i==0)
	break;
	cout<<i<<endl;
	
}