#include <iostream>
#include <locale.h>
#include <fstream>
using namespace std;

int main(int argc, char** argv)
{
	setlocale(LC_ALL, "");
	
	string linha;
	bool flag = false;
	int copyI;
	ifstream arq("arq.txt");
	
	if (arq.is_open()) {
		while (! arq.eof()) {
			getline(arq, linha);
			flag = false;
			for(int i = linha.size() - 1; flag != true; i--) {
				if (linha[i] == ' ') {
					copyI = i;
					for (; i < linha.size(); i++) {
						cout << linha[i];
					}
					cout << ", ";
					for (int j = 0; j < copyI; j++) {
						cout << linha[j];
					}
					cout << endl;
					flag = true;
				}
			}
		}
		arq.close();
	}
	else {
		cout << "Erro ao abrir o arquivo";
	} 

	return 0;
}