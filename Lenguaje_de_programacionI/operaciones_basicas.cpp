#include <iostream>
int main(){
    float numero1, numero2;
    
    std::cout << "Escribe el primer número: "; // se solicita primer número
    std::cin >> numero1;  // se guarda en variable
    std::cout << "Escribe el segundo número: "; // se solicita un segundo número
    std::cin >> numero2; // se guarda en variable
    
    float suma = numero1 + numero2; // suma de ambos numeros y se guarda en variable
    float resta = numero1 - numero2; // resta de ambos numeros y se guarda en variable 
    float multiplicacion = numero1 * numero2; // multiplicación de ambos numeros y se guarda en variable suma
    float division = numero1 / numero2; // división de ambos numeros y se guarda en variable suma   
    
    std::cout << "La suma es: " << suma << std::endl; // se imprime resultado de suma
    std::cout << "La resta es: " << resta << std::endl; // se imprime resultado de resta
    std::cout << "La multiplicación es: " << multiplicacion << std::endl; // se imprime resultado de multiplicación
    
     if (numero2 != 0){  // se valida si el segundo número es diferente a cero
        std::cout << "La división es: " << division << std::endl; // de ser True, se realiza imprime resultado de división
    } else {
        std::cout << "La división es: Error, no se puede dividir entre 0" << std::endl; // de ser false manda mensaje de error
    }   
    
    return 0;
}