#include <iostream>
#include <locale.h>
#include <iomanip>
#include <windows.h>
using namespace std;

void gotoxy(int x, int y) {
	HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);
    static COORD    coord;
    coord.X = x; coord.Y = y;
    SetConsoleCursorPosition(console, coord);
    return;
}

int main(int argc, char** argv)
{
	string frase, f2;

	cout << "Digite sua frase" << endl;
	cin >> frase;

	f2 = frase;
	
	system("cls");
	
	
	for (int i = 0; i < frase.size(); i++) {
		gotoxy(60, 0);
		cout << frase;
		f2.replace(i, 1, " ");
		gotoxy(60, 0);
		cout << f2;
		
		for (int j = 1; j <= 20; j++) {
			gotoxy(60 + i, j);
			cout << frase[i] << endl;
			Sleep(50);
			gotoxy(60 + i, j);
			if (j < 20) {
				cout << " ";
			}
		}
		frase.replace(i, 1, " ");
	}
	
	
	return 0;
}