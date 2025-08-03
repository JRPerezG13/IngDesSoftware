#include <iostream>

using namespace std;
int main() {
    int edad; // variable de número entero para guardar la edad
    cout << "Por favor, ingresa tu edad: "; //cout para ingresar mensaje de salida
    cin >> edad; // cin es valor ingreso y se guarda en variable edad

    if (edad >= 18) { // primer condicionante, edad mayor o igual a 18
        cout << "Eres mayor de edad." << endl; //Mensaje de salida si la lógica es Verdadera
    } else { 
        cout << "Eres menor de edad." << endl; //Mensaje de salida si la lógica es Falsa
    }

    return 0;
}