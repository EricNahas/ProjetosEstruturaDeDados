#include <iostream>
#include <locale.h>
#include <fstream>
using namespace std;

int main(int argc, char** argv)
{
	setlocale(LC_ALL, "");
	
	string linha;
	bool flag = false;
	bool nome = false;
	int copyI;
	ifstream arq("arq.txt");
	
	if (arq.is_open()) {
		while (! arq.eof()) {
			getline(arq, linha);
			flag = false;
			nome = false;
			for(int i = linha.size() - 1; flag != true; i--) {
				if (linha[i] == ' ') {
					copyI = i;
					for (; i < linha.size(); i++) {
						cout << (char)toupper(linha[i]);
					}
					
					cout << ", ";
					
					for (int j = 0; flag != true; j++) {
						if (j == copyI) {
							flag = true;
							break;
						}
						
						if (nome == false) {
							cout << linha[j];
						}
						if (linha[j] == ' ') {
							nome = true;
							cout << linha[j + 1] << ". ";
						}
						if (linha[j] == '\n') {
							cout << endl;
						}
						
					}
					cout << endl;
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