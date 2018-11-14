#include <iostream> 
using namespace std;

void numpat(int n)
{
	int num = 26;


	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j <= i; j++)
		{

			cout << num << " ";

		
			num = num - 1;
		}
		cout << endl;
	}
}

int main()
{
	int n = 7;
	numpat(n);
	system("pause");
	return 0;
}
