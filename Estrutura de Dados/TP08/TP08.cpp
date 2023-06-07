#include <iostream>
using namespace std;

void print(int t, int *a) {
	cout << "----------------------" << endl;
	for(int i=0; i<t; ++i) {
		cout << "Elemento: " << i << " = " << a[i] << endl;
	}
	cout << "----------------------" << endl;
}

void bubble_sort_recursiv(int t, int *a) {
	int aux;
		for(int j=0; j<(t-1); ++j) {
			cout << "[" << j << "]: " << a[j] << 
			        ", [" << j+1 << "]:  " << a[j+1];
			if (a[j] > a[j+1]) {
				aux = a[j];
				a[j] = a[j+1];
				a[j+1] = aux;
				cout << " - Trocou!!!";
			}
			cout << endl;
		}
        if (t>1) {
			bubble_sort_recursiv(t-1, a);
		}
}

void insertion_sort(int x[], int t) {
	int aux;
	for(int i = 0; i < (t - 1); i++) {
		for (int j = i + 1; j <= t; ++j) {
			if (x[j] < x[i]) {
				aux = x[j];
				x[j] = x[i];
				x[i] = aux;
				
				for (int k = i; k > 0; k--) {
					if (x[k] < x[k - 1]) {
						aux = x[k];
						x[k] = x[k - 1];
						x[k - 1] = aux;
					}
					else {
						break;
					}
				}
			}
			else {
				break;
			}
		}
	}
}


void quick_sort(int x[], int ini, int t) {
	int pivo = t, i = ini, aux;
	
	
	for(int j = ini; j < t; j++) {
		if (x[j] <= x[pivo]) {
			aux = x[j];
			x[j] = x[i];
			x[i] = aux;
			i++;
		}
	}
	aux = x[i];
	x[i] = x[pivo];
	x[pivo] = aux;
	
	aux = pivo;
	pivo = i;
	i = aux;

	if ((pivo + 1) < t) {
		quick_sort(x, pivo + 1, t);
	}
	
	if (ini < (pivo - 1)) {
		quick_sort(x, ini, pivo - 1);
	}
	
}


int main(int argc, char** argv)
{
	int v[8] = {49, 38, 58, 87, 34, 93, 26, 13};
	//insertion_sort(v, 8);
	//print(8, v);
	quick_sort(v, 0, 7);
	print(8, v);
	//bubble_sort_recursiv(8, v);
	//print(8, v);
	
	
	return 0;
}