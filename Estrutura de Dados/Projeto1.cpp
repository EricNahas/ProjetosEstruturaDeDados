#include <iostream>
#include <locale.h>
#include <stdlib.h>
using namespace std;

int main(int argc, char** argv)
{
	int **matriz = new int*[15];
	
	for (int i = 0; i < 15; ++i) 
	{
		matriz[i] = new int[40];
	}
	
	
	for (int i = 0; i < 15; i++) {
		for (int j = 0; j < 40; j++) {
			matriz[i][j] = 0;
		}
	}
	
	
	
	
	setlocale(LC_ALL, "");
	int fakebool = 1;
	int escolha;
	int poltrona;
	int fileira;
	int ocupados = 0;
	int valorBilheteria = 0;
	
	while (fakebool != 0) {
		cout << endl;
		cout << "---------------------" << endl;
		cout << "0. Finalizar" << endl;
	   	cout << "1. Reservar poltrona" << endl;
	   	cout << "2. Mapa de ocupação" << endl;
		cout << "3. Faturamento" << endl;
		cout << "---------------------";
		cout << endl << endl;
		cout << "Digite sua opção: ";
		cin >> escolha;
		cout << endl;
		
		
		switch (escolha) {
			case 0:
				fakebool = 0;
				cout << "Obrigado por utilizar o sistema! Até mais!" << endl;
				break;
			
			//---------------------------------------------------------------------------------------------------//
			
			case 1:
				system("cls");
				do {
					cout << "Digite o número da fileira desejada (entre 1 e 15): " << endl;
				   	cin >> fileira;
				   	if (fileira < 1 || fileira > 15) {
						   cout << "Valor inválido, redigite!" << endl << endl;
					   }
				}
				while (fileira < 1 || fileira > 15);
				
				do {
					cout << "Digite o número da poltrona (entre 1 e 40): " << endl;
					cin >> poltrona;
					if (poltrona < 1 || poltrona > 40) {
						cout << "Valor inválido, redigite!" << endl << endl;
					}
				}
				while (poltrona < 1 || poltrona > 40);
				
				
				if (matriz[fileira - 1][poltrona - 1] == 0) {
					
					cout << "Lugar reservado!" << endl;
					ocupados++;
					matriz[fileira - 1][poltrona - 1] = 1;
					
					if (fileira < 6) {
						valorBilheteria += 50;
					}
					else if (fileira > 10) {
						valorBilheteria += 15;
					}
					else {
						valorBilheteria += 30;
					}
					
				}
				else {
					
					cout << "Esse lugar já está ocupado!" << endl;
					
				}
				
				break;
			
			//---------------------------------------------------------------------------------------------------//
			
			case 2:
				system("cls");
				for (int i = 0; i < 15; i++) {
					for (int j = 0; j < 40; j++) {
						if (matriz[i][j] == 0) {
							cout << "." << " ";
						}
						else {
							cout << "#" << " ";
						}
					}
					cout << endl;
				}
				cout << endl << "'.' São lugares vagos" << endl << "'#' São lugares ocupados" << endl << endl;
				break;
			
			//---------------------------------------------------------------------------------------------------//
			
			case 3:
				system("cls");
				cout << "Quantidade de lugares ocupados: " << ocupados << endl;
				cout << "Valor da Bilheteria: R$" << valorBilheteria << endl;
				break;
			
			default:
				cout << "Você digitou uma opção inexistente!" << endl << "Digite novamente..." << endl;
				break;
				
		}
		
	}
	
	
	return 0;
}