// ��Ϊ���������ĳ�����Ʒ������Ľ�ʦ����������2016-3-8��
#include <iostream>
using namespace std;

#define N 9
// ������������������ĳ�����Ʒ������Ѿ�������
// ������֮���໥�����ù�ϵ����Ķ����Ե���Щ�������������˳���Ա�Ա��뼼�������
class clsGirl;   // Ů�������ǰ��˵������Ϊ�к���Missing������
class clsBoy
{
public:
	void MissingGirl(clsGirl &Girl, int n);
};

class clsGirl
{
public:
	void MissingBoy(clsBoy &Boy, int n);
};

// �к���N������Girl���������
void clsBoy::MissingGirl(clsGirl &Girl, int n)
{
	if(n<N)
		cout<<"Boy Missing Girl "<<n<<" times"<<endl;
	else
		cout<<"Boy: Let us togather"<<endl; // �к����
	Girl.MissingBoy(*this, n);      // �к�����ȴ�Ů���Ļ�Ӧ
}

// Ů����N�λ�Ӧ������ͬ�����
void clsGirl::MissingBoy(clsBoy &Boy, int n)
{
	if(n<N)
	{
		cout<<"Girl Missing Boy "<<n<<" times"<<endl;
		Boy.MissingGirl(*this, n+1); // Ů������������Ϸ����������һ��
	}
	else
		cout<<"Girl: We are togather"<<endl; // Ů��Ը��
}

void main()
{
    clsBoy Boy;  clsGirl Girl;  // һ���к���һ��Ů��������
	Boy.MissingGirl(Girl, 1);   // ���к���ʼ������
	Girl.MissingBoy(Boy, 1);    // ��Ů����ʼ������
}