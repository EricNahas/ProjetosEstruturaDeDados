#include <iostream>
#include <locale.h>
#include <string>
using namespace std;

class Data
{
	private:
		int dia;
		int mes;
		int ano;
    public:
    	Data(int dia, int mes, int ano) {
			this->dia = dia;
            this->mes = mes;
			this->ano = ano;			
		}
    	Data() {
			this->dia = 0;
            this->mes = 0;
			this->ano = 0;			
		}
		void setDia(int dia) {
			this->dia = dia;
		}
		void setMes(int mes) {
			this->mes = mes;
		}
		void setAno(int ano) {
			this->ano = ano;
		}
		int getDia() {
			return this->dia;
		}
		int getMes() {
			return this->mes;
		}
		int getAno() {
			return this->ano;
		}
		
        Data* dia_seguinte()
		{
			Data *d1;
			int diasNoMes[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
			d1 = new Data(this->dia, this->mes, this->ano);
			if (d1->ano%4==0)
			{
				diasNoMes[1]++;
			}
			d1->dia++;
			if(d1->dia > diasNoMes[d1->mes-1])
			{
				d1->dia = 1;
				if (++d1->mes > 12)
				{
					d1->mes = 1;
					d1->ano++;
				}
			}
			return d1;
		}
		 	
};

class Contato {
	private:
		string email;
		string nome;
		string telefone;
		Data dtnasc;

	public: 
		
	
		Contato() {
			this->email = "Invalid";
			this->nome = "Invalid";
			this->telefone = "Invalid";
	   	}
	   	
	   	Contato(string email, string nome, string telefone, Data dtnasc) {
            this->email = email;
			this->nome = nome;
			this->telefone = telefone;
			this->dtnasc = dtnasc;
	    }
	    
	    void setEmail(string email) {
			this->email = email;
		}
		
		void setNome(string nome) {
			this->nome = nome;
		}
		
		void setTelefone(string telefone) {
			this->telefone = telefone;
		}
		
		void setDtnasc(Data dtnasc) {
			this->dtnasc = dtnasc;
		}
		
		string getEmail() {
			return this->email;
		}
		
		string getNome() {
			return this->nome;
		}
		
		string getTelefone() {
			return this->telefone;
		}
		
		Data getDtnasc() {
			return this->dtnasc;
		}
		
		int Idade() {
			int idade = 2023 - dtnasc.getAno();
			return idade;
		}
		
};

int main(int argc, char** argv)
{
	Data array[5];
	Contato arrayC[5];
	
	string Nome, Telefone, Email;
	int DtNasc;
	
	for (int x = 0; x < 5; x++) {
		
		cout << "Escreva o ano de nascimento" << endl;
		cin >> DtNasc;
		array[x].setAno(DtNasc);
		arrayC[x].setDtnasc(array[x]);
		
		cout << "Digite o nome" << endl;
		cin >> Nome;
		arrayC[x].setNome(Nome);
		
		cout << "Digite o email" << endl;
		cin >> Email;
		arrayC[x].setEmail(Email);
		
		cout << "Digite o telefone" << endl;
		cin >> Telefone;
		arrayC[x].setTelefone(Telefone);
		
	}
	
	for (int y = 0; y < 5; y++) {
		cout << "-------------------------" << endl;
		cout << "Nome: " << arrayC[y].getNome() << endl;
		cout << "Email: " << arrayC[y].getEmail() << endl;
		cout << "Telefone: " << arrayC[y].getTelefone() << endl;
		cout << "Idade: " << arrayC[y].Idade() << endl;
		cout << "-------------------------" << endl;
	}
	
	
	return 0;
}