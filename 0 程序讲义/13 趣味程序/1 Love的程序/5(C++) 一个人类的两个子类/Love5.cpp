// ��Ϊ���������ĳ�����Ʒ������Ľ�ʦ����������2016-3-8��
#include <iostream>
using namespace std;

#define N 9
// ������������������ĳ�����Ʒ��������Գ�ʦ��
// ����������������Ϊ�к����Ů����Ĺ��ԣ����˳���ṹ
class clsYoung   // ��������
{
public:
	// ֻҪ�����ഺ������˼��
	void virtual Missing(clsYoung &Young, int n)=0;
};

class clsBoy: public clsYoung  // �к���һ��������
{
public:
	// �к���N������Girl���������
	void virtual Missing(clsYoung &Girl, int n)
	{
		if(n<N)
			cout<<"Boy Missing Girl "<<n<<" times"<<endl;
		else
			cout<<"Boy: Let us togather"<<endl; // �к����
		Girl.Missing(*this, n);      // �к�����ȴ�Ů���Ļ�Ӧ
	}
};

class clsGirl: public clsYoung  // Ů����һ��������
{
public:
	// Ů����N�λ�Ӧ������ͬ�����
	void virtual Missing(clsYoung &Boy, int n)
	{
		if(n<N)
		{
			cout<<"Girl Missing Boy "<<n<<" times"<<endl;
			Boy.Missing(*this, n+1); // Ů������������Ϸ����������һ��
		}
		else
			cout<<"Girl: We are togather"<<endl; // Ů��Ը��
	}
};

void main()
{
    clsBoy Boy;	clsGirl Girl;  // һ���к���һ��Ů��������
	Boy.Missing(Girl, 1);      // ���к���ʼ������
	Girl.Missing(Boy, 1);      // ��Ů����ʼ������
}