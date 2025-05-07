
#include<iostream>
using namespace std;
int main()
{
	char op ;
	double num1 , num2;
	for(;;){
	cout<<"enter the first number : ";
	cin>>num1;
	cout<<"enter operator(- , + , * , / ) : ";
	cin>>op;
	cout<<"enter the second number :";
	cin>>num2;
	switch(op){
	case '+':
	cout<<num1<<"+"<<num2<<"="<<num1+num2;
	break;
	case '-':
	cout<<num1<<"-"<<num2<<"="<<num1-num2;
	break;
	case'*':
	cout<<num1<<"*"<<num2<<"="<<num1*num2;
	break;
	case '/':{
	if(num2==0)
	cout<<"error";
	cout<<num1<<"/"<<num2<<"="<<num1/num2;
	}break;
	default:
	cout<<"error ! the not correct";
	}cout<<"\n**********"<<endl;
	}
}