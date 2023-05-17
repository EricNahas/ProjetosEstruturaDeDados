#include <iostream>
#include <locale.h>
using namespace std;
#define MAX 10

struct Armazena
{
	int qtd;
	int elementos[MAX];
	
};

Armazena* init() {
	Armazena *n = new Armazena();
	n->qtd = 0;
	return n;
}

Armazena* guardaValor(Armazena *n) {
	int valor = -1;
	while(valor == -1 || valor <= n->elementos[n->qtd-1])
	{
		cout << "Digite o valor desejado: " << endl;
		cin >> valor;
		
		if(valor == -1 || valor <= n->elementos[n->qtd-1]) {
			cout << "VALOR INDESEJADO! REDIGITE!" << endl;
		}
		else
		{
			n->elementos[n->qtd] = valor;
			++n->qtd;
			break;
		}
	}
}

/////////////////////////////////////////////////////////////////////////


struct ArmazenaImpar {
	int elementosImpares[MAX];	
	int qtd;
};

ArmazenaImpar* initImpar() {
	ArmazenaImpar *imp = new ArmazenaImpar;
	imp->qtd = 0;
	return imp;
}


ArmazenaImpar* guardaImpar(Armazena *x, ArmazenaImpar *imp) {
	for (int i = 0; i < MAX; i++) {
		if (x->elementos[i] % 2 != 0) {
			imp->elementosImpares[imp->qtd] = x->elementos[i];
			imp->qtd++;
		}
	}
}

ArmazenaImpar* mostraImpar(ArmazenaImpar *imp) {
	cout << "OS NUMEROS IMPARES SAO: " << endl;
	cout << "------------------------" << endl;
	for (int i = imp->qtd-1; i >= 0; i--) {
		cout << imp->elementosImpares[i] << endl;
	}
}

int popImpar(ArmazenaImpar *imp) {
	int v;
	if (imp->qtd != 0) {
		v = imp->elementosImpares[imp->qtd-1];
		imp->qtd--;
	}
	else {
		v = -1;
	}
	return v;
}

/////////////////////////////////////////////////////////////////////////////

struct ArmazenaPar {
	int elementosPares[MAX];	
	int qtd;
};

ArmazenaPar* initPar() {
	ArmazenaPar *par = new ArmazenaPar;
	par->qtd = 0;
	return par;
}


ArmazenaPar* guardaPar(Armazena *x, ArmazenaPar *par) {
	for (int i = 0; i < MAX; i++) {
		if (x->elementos[i] % 2 == 0) {
			par->elementosPares[par->qtd] = x->elementos[i];
			par->qtd++;
		}
	}
}

ArmazenaPar* mostraPar(ArmazenaPar *par) {
	cout << "OS NUMEROS PARES SAO: " << endl;
	cout << "------------------------" << endl;
	for (int i = par->qtd-1; i >= 0; i--) {
		cout << par->elementosPares[i] << endl;
	}
}


int popPar(ArmazenaPar *par) {
	int v;
	if (par->qtd != 0) {
		v = par->elementosPares[par->qtd-1];
		par->qtd--;
	}
	else {
		v = -1;
	}
	return v;
}

//////////////////////////////////////////////////////////////////////////

int main(int argc, char** argv)
{
	Armazena *teste = new Armazena();
	teste = init();
	for (int i = 0; i < MAX; i++) {
		guardaValor(teste);
	}
	cout << endl;
	
	ArmazenaImpar *testeImpar = new ArmazenaImpar;
	testeImpar = initImpar();
	guardaImpar(teste, testeImpar);
	mostraImpar(testeImpar);	
	cout << endl;
	ArmazenaPar *testePar = new ArmazenaPar;
	testePar = initPar();
	guardaPar(teste, testePar);
	mostraPar(testePar);
	
	cout << endl;
	
	cout << "VAMOS SUMIR COM OS IMPARES" << endl;
	for (int i = MAX; i >= 0; i--) {
		cout << popImpar(testeImpar) << " - apagado!" << endl;
	}
	
	cout << endl;
	
	cout << "VAMOS SUMIR COM OS PARES" << endl;
	for (int i = MAX; i >= 0; i--) {
			cout << popPar(testePar) << " - apagado!" << endl;
	}



	
	return 0;
}