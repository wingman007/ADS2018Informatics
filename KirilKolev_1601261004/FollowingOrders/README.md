# Duke programming contest, 1993, problem g.

Order is an important concept in mathematics and in computer science. For example, Zorn's Lemma states: ``a partially ordered set in which every chain has an upper bound contains a maximal element.'' Order is also important in reasoning about the fix-point semantics of programs.  

This problem involves neither Zorn's Lemma nor fix-point semantics, but does involve order.  
Given a list of variable constraints of the form x < y, you are to write a program that prints all orderings of the variables that are consistent with the constraints.  

For example, given the constraints x < y and x < z there are two orderings of the variables x, y, and z that are consistent with these constraints: x y z and x z y.

### Prerequisites

This task is from the "Programming = ++ Algorithms" Book.
Here is a link from where you can download the book: http://www.programirane.org/download-now/ .
Task number is 5.89, on page 353.

## Details

The program is writen in C++ programming language.

Here is an online compiler where you can run the program: https://www.onlinegdb.com/online_c++_compiler

Just copy the code and paste it in the compiler:
```
#include <cstdio>
#include <iostream>
#include <cstdlib>
#include <algorithm>
#include <ctime>
#include <cctype>
#include <cmath>
#include <string>
#include <cstring>
#include <stack>
#include <queue>
#include <list>
#include <vector>
#include <map>
#include <set>
#define sqr(x) ((x)*(x))
#define LL long long
#define itn int
#define INF 0x3f3f3f3f
#define PI 3.1415926535897932384626
#define eps 1e-10
#define maxm 
#define maxn 

using namespace std;

bool appear[30],pending[30],G[30][30];
int deg[30],st[30];
int n;

void write()
{
	for (int i=0;i<n;i++)
		putchar(st[i]+'a');
	putchar ( '\n');
}

void toposort(int x,int top)
{
	st[++top]=x;
	if (top+1==n)
	{
		write();
		return ;
	}
	
	for (int i=0;i<30;i++)
	{
		if (G[x][i])
		{
			deg[i]--;
			if (deg[i]==0)
			{
				pending[i]=true;
			}
		}
	}
	
	for (int i=0;i<30;i++)
	{
		if (pending[i])
		{
			pending[i]=false;
			toposort(i,top);
			pending[i]=true;
		}
	}
	
	for (int i=0;i<30;i++)
	{
		if (G[x][i])
		{
			deg[i]++;
			if (deg[i]!=0)
			{
				pending[i]=false;
			}
		}
	}
}

void slove()
{
	memset(pending,0,sizeof pending);
	for (int i=0;i<30;i++)
	{
		if (appear[i] && deg[i]==0)
			pending[i]=true;
	}
	
	for (int i=0;i<30;i++)
	{
		if (pending[i])
		{
			pending[i]=false;
			toposort(i,-1);
			pending[i]=true;
		}
	}
}

int main()
{
	char last,ch;
	int cnt=0;
	bool first=true,cmp=false;
	memset(appear,0,sizeof appear);
	memset(G,0,sizeof G);
	memset(deg,0,sizeof deg);
	
	while ( (ch=getchar())!=EOF)
	{
		if (ch==' ')	continue;
	
		if (ch=='\n')
		{
			cnt++;
		}
		if (cnt==0)
		{
			appear[ch-'a']=true;
			n++;
		}
		
		if (cnt==1)
		{
			if (ch=='\n') continue;
			if (cmp)
			{
				cmp=false;
				if (G[last-'a'][ch-'a'])	continue;
				G[last-'a'][ch-'a']=true;
				deg[ch-'a']++;
			}
			else
			{
				cmp=true;
				last=ch;
			}
		}
		
		if (cnt==2)
		{
			if (!first)	putchar( '\n');
			first=false;
			slove();
			memset(appear,0,sizeof appear);
			memset(G,0,sizeof G);
			memset(deg,0,sizeof deg);
			cnt=n=0;
		}
	}
	
	return 0;
}

```

## Credit:

http://www.voidcn.com/article/p-zwnrhiih-zs.html