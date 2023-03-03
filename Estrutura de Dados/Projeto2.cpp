#include <iostream>
#include <locale.h>
#include <math.h>
#include <iomanip>
#include <cstdlib>
#include <ctime>

using namespace std;

int main(int argc, char** argv)
{
	setlocale(LC_ALL, "");
	
	int **baralho = new int*[2];
	int naipe = 1;
	int ncarta = 1;
	int prefixo = 0;
	int cont = 0;
	int mao1 =0, mao2 =0, mao3 =0, mao4 =0;
	unsigned seed = time(NULL);
	srand(seed);
	int *p1 = new int[11];
	int *p2 = new int[11];
	int *p3 = new int[11];
	int *p4 = new int[11];
	int A;
	int B;
	int C;
	int D;
	int E;
	
	
	for (int i = 0; i < 2; i++) {
		baralho[i] = new int[52];
	}
	
	for (int i = 0; i < 2; i++) {
		naipe = 1;
		for (int j = 0; j < 52; j++) {
			cont++;

			baralho[i][j] = (naipe * 1000) + (prefixo * 100) + (ncarta *(10)) + (i);
			
			ncarta++;
			if (ncarta == 10) {
				ncarta = 0;
				prefixo = 1;
			}
			if (prefixo == 1 && ncarta > 3) {
				prefixo = 0;
				ncarta = 1;
			}
			
			if (cont % 13 == 0) {
				naipe++;
			}
		}
	}
	
	for (int i = 0; i < 2; i++) {
		for (int j = 0; j < 52; j++) {
				
			A = rand() % 52;
			B = rand() % 2;
			C = baralho[B][A];
			D = rand() % 52;
			E = rand() % 2;
			
			baralho[B][A] = baralho[E][D];
			baralho[E][D] = C;
			
		}
	}
	
	for (int i = 0; i < 44; i++) {
		if (i < 11) {
			p1[mao1] = baralho[0][i];
			cout << mao1 + 1 << "ª carta do Jogador 1: " << p1[mao1] << endl;
			mao1++;
		}
		if (i == 11) {
			cout << "-----------------------------------------------------" << endl;
		}
		if (i >= 11 && i < 22) {
			p2[mao2] = baralho[0][i];
			cout << mao2 + 1 << "ª carta do Jogador 2: " << p2[mao2] << endl;
			mao2++;
		}
		if (i == 22) {
			cout << "-----------------------------------------------------" << endl;
		}
		if (i >= 22 && i < 33) {
			p3[mao3] = baralho[0][i];
			cout << mao3 + 1 << "ª carta do Jogador 3: " << p3[mao3] << endl;
			mao3++;
		}
		if (i == 33) {
			cout << "-----------------------------------------------------" << endl;
		}
		if (i >= 33) {
			p4[mao4] = baralho[0][i];
			cout << mao4 + 1 << "ª carta do Jogador 4: " << p4[mao4] << endl;
			mao4++;
		}
	}
	
	
	
	return 0;
}