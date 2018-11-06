#include <iostream>
using namespace std;

int main()
{
	const double pi = 3.14;
	double radius, area, circumference;

	cout << "please input radius : ";
	cin >> radius;
	cout << endl;

	circumference = 2 * pi * radius;
	area = pi * radius * radius;

	cout << "area :  " << area << endl;

	cout << "circumference : " << circumference << endl;

	cin.ignore(1000, '\n');
	cin.get();
}