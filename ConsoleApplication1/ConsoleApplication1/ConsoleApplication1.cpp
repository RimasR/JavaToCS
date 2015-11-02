#include <iostream>

using namespace std;

int main()
{
	double a[100][100]; //kvadratinis masyvas
	int n, m; //eiluciu ir stulpeliu skaicius
	cin >> n;
	cin >> m;
	int d = 0; //skaitliukas
	int s = 0; //suma
	int v = 0; // aritmetinis vidurkis

	if (n != m) return 0;// jei ne kvadratinis masyvas, programa baigia darba


	for (int i = 0; i<n; i++)
	{
		for (int j = 0; j<m; j++)
		{
			cin >> a[i][j];//nariu ivedimas
			if ((i>j) && (a[i][j]>0)) { //jeigu zemiau pagr. istrizaines ir teigiamas narys
				s = +a[i][j]; //suma
				d++; //skaitliukas zymi, kiek tokiu nariu
			}
		}
	}
	v = s / d;
	cout << v;
	return 0;
}
