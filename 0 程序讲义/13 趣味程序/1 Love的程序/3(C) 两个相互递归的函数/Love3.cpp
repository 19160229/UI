// ��Ϊ��������ƻ������Ľ�ʦ����������2016-3-8��
#include <iostream>
using namespace std;

// ������һ�������Ϸ����Ҫ�㳪�Һ�
// ��ע���к���Ů���ĺ����ṹ���ڱ�Ȼ�Ĳ���
// �к�����������ɻ��������󣬱���ȴ�Ů���Ļ�Ӧ
// Ů����������ʱ���������������Ϸ����ʱ�������������
#define N 9
void BoyMissingGirl(int n);
void GirlMissingBoy(int n);

void main()
{   
	BoyMissingGirl(1); 
}

// �к���N��������������
void BoyMissingGirl(int n)
{
	if(n<N)
		cout<<"Boy Missing Girl "<<n<<" times"<<endl;
	else
		cout<<"Boy: Let us togather"<<endl; // �к����
	GirlMissingBoy(n);      // �к�����ȴ�Ů���Ļ�Ӧ
}
// Ů����N�λ�Ӧ������ͬ�����
void GirlMissingBoy(int n)
{
	if(n<N)
	{
		cout<<"Girl Missing Boy "<<n<<" times"<<endl;
		BoyMissingGirl(n+1); // Ů������������Ϸ����������һ��
	}
	else
		cout<<"Girl: We are togather"<<endl; // Ů��Ը��
}

