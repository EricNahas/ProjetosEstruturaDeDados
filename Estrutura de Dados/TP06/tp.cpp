#include <iostream>
#include <locale.h>
using namespace std;

struct No {
	float dado;
	struct No *prox;
};

struct Fila {
	No *ini;
	No *fim;
};

Fila* init() {
	Fila *f = new Fila;
	f->ini = NULL;
	f->fim = NULL;
	return f;
}

int isEmpty(Fila *f) {
	return (f->ini == NULL);
}

int count(Fila *f) {
	int qtde = 0;
	No *no;
	no = f->ini;
	while(no != NULL) {
		qtde++;
		no = no->prox;
	}
	return qtde;
}

void print(Fila *f) {
	No *no;
	no = f->ini;
	cout << "------------" << endl;
	while(no != NULL) {
		cout << no->dado << endl;
		no = no->prox;
	}
	cout << "------------" << endl;
}

void freeFila(Fila *f) {
	No *no = f->ini;
	while (no != NULL) {
		No *temp = no->prox;
		
		no = temp;
	}
	
}

// Enfileirar
void enqueue(Fila *f, float v) {
	No *no = new No;
	no->dado = v;
	no->prox = NULL;
	if (isEmpty(f)) {
	   f->ini = no;
	}
	else {
		f->fim->prox = no;
	}
	f->fim = no;
}


// Desenfileirar
float dequeue(Fila *f) {
	float ret;
	if (isEmpty(f)) {
		ret = -1;
	}
	else {
		No *no = f->ini;
		ret = no->dado;
		f->ini = no->prox;
		if (f->ini == NULL) {
			f->fim = NULL;
		}
		
	}
	return ret;
}

int main(int argc, char** argv)
{
	setlocale(LC_ALL, "Portuguese");
	Fila *filaFloat;
	filaFloat = init();
	
	int seletor;
	int incrementoSenha = 0;
	
	do {
		if (count(filaFloat) != 0) {
			cout << "--------------------------------------" << endl;
			cout << count(filaFloat) << " senhas aguardando atendimento!" << endl;
			cout << "--------------------------------------" << endl;
		}
		else {
			cout << "--------------------------------------" << endl;
			cout << "Não há senhas na fila!" << endl;
			cout << "--------------------------------------" << endl;
			cout << endl;
		}
		
		cout << endl;
		
		cout << "0 - Sair" << endl;
		cout << "1 - Gerar senha" << endl;
		cout << "2 - Realizar atendimento" << endl;
		cout << endl;
		
		cin >> seletor;
		
		cout << endl;
		
		if (seletor == 0 && isEmpty(filaFloat) == false) {
			cout << "Ainda há senhas para serem atendidas!" << endl;
		}
		else if (seletor == 0 && isEmpty(filaFloat) == true) {
			cout << incrementoSenha << " senhas foram atendidas!" << endl;
		}
		
		switch(seletor)
		{
        case 0:
        	break;
				
		case 1:
			incrementoSenha++;
			enqueue(filaFloat, incrementoSenha);
			cout << "--------------------------------------" << endl;
			cout << "Sua senha é a número: " << incrementoSenha << endl;
			cout << "--------------------------------------" << endl;
			break;
		
		case 2:
			if (isEmpty(filaFloat) == false) {
				cout << "--------------------------------------" << endl;
			   	cout << "Senha " << dequeue(filaFloat) << " foi atendida!" << endl;
				cout << "--------------------------------------" << endl;
			}
			else {
				cout << "--------------------------------------" << endl;
				cout << "Não há senhas a serem atendidas!" << endl;
				cout << "--------------------------------------" << endl;
			}
			
			break;
		
		default:
			cout << "Número digitado inválido!" << endl;
			break;
		}
		
		if (seletor == 0 && isEmpty(filaFloat) == false) {
			seletor = 3;
		}
	}
	while(seletor != 0);
	
	
	return 0;
}