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


void selection_sort(int x[], int t) {
    int n = t;
    
    for (int i = 0; i < n - 1; ++i) {
        int minIndex = i;
        for (int j = i + 1; j < n; ++j) {
            if (x[j] < x[minIndex]) {
                minIndex = j;
            }
        }
        swap(x[i], x[minIndex]);
    }
}

void merge_sort(int x[], int left, int right) {
    if (left < right) {
        int middle = left + (right - left) / 2;

        merge_sort(x, left, middle);
        merge_sort(x, middle + 1, right);

        int n1 = middle - left + 1;
	    int n2 = right - middle;
	
	    int L[n1];
	    int R[n2];
	
	    for (int i = 0; i < n1; ++i) {
	        L[i] = x[left + i];
	    }
	    for (int j = 0; j < n2; ++j) {
	        R[j] = x[middle + 1 + j];
	    }
	
	    int i = 0;
	    int j = 0;
	    int k = left;
	
	    while (i < n1 && j < n2) {
	        if (L[i] <= R[j]) {
	            x[k] = L[i];
	            ++i;
	        } 
			else {
	            x[k] = R[j];
	            ++j;
	        }
	        ++k;
	    }
	
	    while (i < n1) {
	        x[k] = L[i];
	        ++i;
	        ++k;
	    }
	
	    while (j < n2) {
	        x[k] = R[j];
	        ++j;
	        ++k;
	    }
    }
}

void shell_sort(int x[], int n) {

    for (int gap = n / 2; gap > 0; gap /= 2) {
        for (int i = gap; i < n; i++) {
            int temp = x[i];
            int j;
            for (j = i; j >= gap && x[j - gap] > temp; j -= gap) {
                x[j] = x[j - gap];
            }
            x[j] = temp;
        }
    }
}


int main(int argc, char** argv)
{	
	int v[8] = {49, 38, 58, 87, 34, 93, 26, 13};
	
	/*
	cout << "ESSE É O INSERTION: " << endl;
	cout << "-------------------" << endl;
	insertion_sort(v, 8);
	print(8, v);
	*/
	
	/*
	v = {49, 38, 58, 87, 34, 93, 26, 13};
	cout << "ESSE É O QUICK: " << endl;
	cout << "-------------------" << endl;
	quick_sort(v, 0, 7);
	print(8, v);
	*/
	
	/*
	v = {49, 38, 58, 87, 34, 93, 26, 13};
	cout << "ESSE É O BUBBLE: " << endl;
	cout << "-------------------" << endl;
	bubble_sort_recursiv(8, v);
	print(8, v);
	*/
	
	/*
	v = {49, 38, 58, 87, 34, 93, 26, 13};
	cout << "ESSE É O SELECTION: " << endl;
	cout << "-------------------" << endl;
	selection_sort(v, 8);
	print(8, v);
	*/
	
	/*
	v = {49, 38, 58, 87, 34, 93, 26, 13};
	cout << "ESSE É O MERGE: " << endl;
	cout << "-------------------" << endl;
	merge_sort(v, 0, 8);
	print(8, v);
	*/
	
	/*
	v = {49, 38, 58, 87, 34, 93, 26, 13};
	cout << "ESSE É O SHELL: " << endl;
	cout << "-------------------" << endl;
	shell_sort(v, 8);
	print(8, v);*/
	
	
	return 0;
}