#include<iostream>

using namespace std;

int main() {

	string hello = "Hello World";

	cout << "variable hello content: "<< hello << ", Memory address (&): "<< &hello << endl;

	string *pHello = &hello;

	cout << "Value stored inside pointer variable: " << pHello << endl;

	return 0;
}