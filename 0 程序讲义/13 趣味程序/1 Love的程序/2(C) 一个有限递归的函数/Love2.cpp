// ��Ϊ��������ƻ������Ľ�ʦ����������2016-3-8��
#include <iostream>
using namespace std;

#define N 9

// N����������ڳ����ǡ�������һ��
void Missingyou(int n)
{
	if(n<=N)
	{
		cout<<"Missing you "<<n<<" times"<<endl;
		Missingyou(n+1);      // ��һ�ε�����
	}
	else
		cout<<"We are together"<<endl;
}

void main()
{
	Missingyou(1);
}

