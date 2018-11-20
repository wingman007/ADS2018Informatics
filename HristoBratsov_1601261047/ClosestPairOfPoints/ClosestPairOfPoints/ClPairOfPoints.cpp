#include <bits/stdc++.h>
using namespace std;
int u;
int v;
long long int bestmin = 10000000000000;
long long int minimum = 10000000000000;
struct points
{
	long long int x;
	long long int y;
	int pos;
};
int xcompare(points a, points b)
{
	return(a.x < b.x);
}
int ycompare(points a, points b)
{
	return (a.y < b.y);
}
long long int dis(points a, points b)
{

	return (((a.x - b.x) * (a.x - b.x)) + ((a.y - b.y) * (a.y - b.y)));

}
long long int brute(points a[], int s, int e)
{
	int i;
	int j;
	int n;
	int c;
	int d;
	int l;
	int r;
	n = e - s + 1;

	for (i = s; i <= e; i++) {
		for (j = i + 1; j <= e; j++) {
			if (dis(a[i], a[j]) < minimum) {
				minimum = dis(a[i], a[j]);
				if (minimum < bestmin) {
					bestmin = minimum;
					u = a[i].pos;
					v = a[j].pos;
				}
			}
		}
	}

	return minimum;
}
long long int findclose(points a[], int k, long long int d)
{


	int i;
	int j;
	long long int min;
	min = d;

	sort(a, a + k, ycompare);


	for (i = 0; i < k; i++) {
		for (j = i + 1; j < k && (a[j].y - a[i].y) < min; j++) {
			if (dis(a[i], a[j]) < min) {
				min = dis(a[i], a[j]);
				if (min < bestmin) {
					bestmin = min;
					u = a[i].pos;
					v = a[j].pos;
				}

			}
		}
	}

	return min;
}
long long int  closepoints(points a[], int s, int e)
{
	int n = e - s + 1;



	int mid = (s + e) / 2;
	int mid1 = a[mid].x;
	if (n <= 3) {
		return  brute(a, s, e);
	}

	long long int l = closepoints(a, s, mid);
	long long int r = closepoints(a, mid + 1, e);
	//cout<<l<<' '<<r<<endl;

	long long int m = min(l, r);

	points b[n];
	int k;
	int i;

	//cout<<mid1<<endl;
	k = 0;

	for (i = s; i <= e; i++) {
		if (abs(mid1 - a[i].x) < m) {
			b[k] = a[i];
			k++;

			//cout<<i<<endl;
		}
	}


	return min(m, findclose(b, k, m));

}
int main()
{
	int n;
	points a[50006];
	int i;

	cout << setiosflags(ios::fixed) << setprecision(6);

	cin >> n;
	for (i = 0; i < n; i++) {
		cin >> a[i].x >> a[i].y;
		a[i].pos = i;
	}

	sort(a, a + n, xcompare);


	closepoints(a, 0, n - 1);
	if (u > v) {
		swap(u, v);
	}
	cout << u << ' ' << v << ' ' << sqrt((double)bestmin) << endl;
}