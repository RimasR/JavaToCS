#include <iostream>

using namespace std;

int main()
{
	int a[50][50];
	int row = 0;
	int col = 0;
	int counter = 0;
	int sum = 0;
	bool valid = false;

	while (!valid)
	{
		cout << "Enter a number (bigger than 1): ";
		cin >> row;
		if (row <= 1)
		{
			cout << "Wrong number!" << endl;
		}
		else
		{
			col = row;
			valid = true;
		}
	}

	for (int i = 0; i<row; i++)
	{
		for (int j = 0; j<col; j++)
		{
			if (i < j) {
				int temp;
				cout << "Enter random number to array place" << i << ";" << j << " : ";
				cin >> temp;
				a[i][j] = temp;
				if (a[i][j] > 0) {
					sum += a[i][j];
					counter++;
				}

			}
		}
	}

	cout << "Sum is equal to: " << sum << endl;
	cout << "Counter is equal to: " << counter << endl;
	double result = (double)sum / counter;
	cout << "Result is equal to: " << result << endl;
	std::getchar();
	return 0;
}
