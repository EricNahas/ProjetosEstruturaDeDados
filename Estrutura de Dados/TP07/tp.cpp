#include <iostream>
#include <locale.h>
#include <sstream>
using namespace std;


struct No {
	float dado;
	struct No *prox;
};

struct Fila {
	No *ini;
	No *fim;
};

struct Guiche {
	int guicheID;
	int controle;
	int senhasAtendidas[20];
};

Guiche* initG(int id){
	Guiche *g = new Guiche();
	g->guicheID = id;
	g->controle = 0;
	return g;
}

int RealizaAtendimento(Fila *f, float ret, Guiche *g[], int caixas) {
	int gui;
	bool x = false;
	
	do {
		cout << "Digite o numero do guiche desejado!" << endl;
		cin >> gui;
		cout << "--------------------------------------" << endl;
		
		for(int i = 0; i < caixas; i++) {
			if(g[i]->guicheID == gui) {
				x = true;
				g[i]->senhasAtendidas[g[i]->controle] = ret;
				g[i]->controle++;
			}
		}
		if (x == false) {
			cout << "--------------------------------------" << endl;
			cout << "Esse guichê não está aberto!" << endl;
			cout << "--------------------------------------" << endl;
		}
	}
	while(x == false);
	
	

	return ret;
}

////////////////////////////////////////


string Listagem(Guiche *g[], int caixas) {
	int gui;
	string ret = "As senhas atendidas foram: \n";
	stringstream ss;
	ss << ret;
	bool x = false;
	
	do {
		cout << "Digite o numero do guiche desejado!" << endl;
		cin >> gui;
		
		for(int i = 0; i < caixas; i++) {
			if(g[i]->guicheID == gui) {
				x = true;
				for(int j = 0; j < g[i]->controle; j++) {
					   ss << g[i]->senhasAtendidas[j] << endl;
				}
				ret = ss.str();
				cout << "--------------------------------------" << endl;
				cout << ret;
				cout << "--------------------------------------" << endl;
			}
		}
		if (x == false) {
			cout << "--------------------------------------" << endl;
			cout << "Esse guichê não está aberto!" << endl;
			cout << "--------------------------------------" << endl;
		}
	}
	while(x == false);
	
	
	return ret;
}






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
	Guiche *atendimento[20];
	filaFloat = init();
	
	int seletor;
	int incrementoSenha = 0;
	int incrementoCaixa = 0;
	
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
		cout << "2 - Abrir guichê" << endl;
		cout << "3 - Realizar atendimento" << endl;
		cout << "4 - Listar senhas atendidas" << endl;
		cout << endl;
		
		cin >> seletor;
		
		cout << endl;
		
		if (seletor == 0 && isEmpty(filaFloat) == false) {
			cout << "--------------------------------------" << endl;
			cout << "Ainda há senhas para serem atendidas!" << endl;
			cout << "--------------------------------------" << endl;
		}
		else if (seletor == 0 && isEmpty(filaFloat) == true) {
			cout << "--------------------------------------" << endl;
			cout << incrementoSenha << " senhas foram atendidas!" << endl;
			cout << "--------------------------------------" << endl;
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
			incrementoCaixa++;
			Guiche *g1;
			g1 = initG(incrementoCaixa);
			atendimento[incrementoCaixa - 1] = g1;
			
			cout << "--------------------------------------" << endl;
			cout << "Guichê " << incrementoCaixa << " está aberto!" << endl;
			cout << "--------------------------------------" << endl;
			break;
		
		
		case 3:
			if (isEmpty(filaFloat) == false && incrementoCaixa != 0) {
				cout << "--------------------------------------" << endl;
			   	cout << "Senha " << RealizaAtendimento(filaFloat, dequeue(filaFloat), atendimento, incrementoCaixa) << " foi atendida!" << endl;
				cout << "--------------------------------------" << endl;
			}
			else {
				cout << "--------------------------------------" << endl;
				cout << "Não há senhas a serem atendidas ou não há guichês abertos!" << endl;
				cout << "--------------------------------------" << endl;
			}
			
			break;
		
		case 4: 
			cout << "--------------------------------------" << endl;
			Listagem(atendimento, incrementoCaixa);
			cout << "--------------------------------------" << endl;
			break;
		
		default:
			cout << "Número digitado inválido!" << endl;
			break;
		}
		
		if (seletor == 0 && isEmpty(filaFloat) == false) {
			seletor = -1;
		}
	}
	while(seletor != 0);
	
	
	return 0;
}