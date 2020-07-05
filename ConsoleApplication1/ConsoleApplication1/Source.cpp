#include <iostream>
#include <string>

using namespace std;

int main() {

	int ReturnCode = 0;

	/*
	float Dividend = 0;
	cout << "enter dividend: ";
	cin>>Dividend;

	float divisor=1;
	cout << "enter divisor: ";
	cin >> divisor;
	
	float result = Dividend*divisor;
	cout << "result is " << result << endl;*/

	float x;
	cout << "Enter a number: ";
	cin >> x;

	// calculate the square root
	float result = sqrt(x);
	cout << "square root of " << x << " is = " << result;
	

	return 0;

}