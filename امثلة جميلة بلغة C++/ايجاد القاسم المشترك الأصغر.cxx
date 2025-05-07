#include<iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int x , y , g , i ;
	cin>>x>>y;
	if(x>y){
		g=x;
	}else {
	g=y;
}
     for(i=g ; i>=g ; i++)
     if(i%x==0 && i%y==0)
     break;
     cout<<i<<endl;
	
}