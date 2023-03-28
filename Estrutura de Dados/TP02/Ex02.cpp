#include <iostream>
#include <locale.h>
#include <iomanip>
using namespace std;


int main(int argc, char** argv)
{
	setlocale(LC_ALL, "");
	string frase, f2;

	cout << "Digite sua frase" << endl;
	cin >> frase;

	
	for (int j = frase.size() - 1; j >= 0; j--) {
		f2 += frase[j];
	}
	
	
	if (frase.compare(f2) == 0) {
		cout << "É palíndromo!";
	}
	else {
		cout << "Não é palíndromo :(";
	}
	
	return 0;
}