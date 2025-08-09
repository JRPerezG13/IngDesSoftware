#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <cctype>

// Diccionario de palabras no permitidas:
const std::vector<std::string> palabras_prohibidas = {
    "PENE", "POPO", "PUTO"
};

// Verificar y modificar palabras prohibidas del Diccionario
std::string corregirRFC(const std::string& rfc) {
    for (const std::string& palabra : palabras_prohibidas){
        if (rfc == palabra) {
            return rfc.substr(0, 3) + "X"; //remplaza última letra por X
        }
    }
    return rfc;
}

// Función para obtener la primera vocal interna de una cadena
char obtenerprimeravocal(const std::string& str){
    for (size_t i = 1; i < str.length(); ++i){
        char c = str[i];
        if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        return c;
    }
    return 'X'; 
}

std::string calcularRFC(const std::string& nombre, const std::string& apellidoPaterno,  const std::string& apellidoMaterno, const std::string& fechanacimiento){
    
    //se declara la variable en donde se guarda el RFC
    std::string rfc;
    
    //se obtiene la letra inicial y la primera vocal del apellido apellidoPaterno
    char letraInicial = apellidoPaterno[0];
    char primeraVocal = obtenerprimeravocal(apellidoPaterno);
    //se obtiene la letra inicial y la primera vocal del apellido apellidoPaterno
    char inicialApellidoaterno = apellidoMaterno[0];
    //se obtiene la inicial del primer nombre
    char inicialNombre = nombre[0];
    // se obtiene los dos ultimos digitos del año de fechanacimiento
    std::string anio = fechanacimiento.substr(8,2);
    // se obtiene mes y dia  de fechanacimiento
    std::string mes = fechanacimiento.substr(3,2);
    std::string dia = fechanacimiento.substr(0,2);
    
    //se contruye el RFC sumando el texto de la info
    
    rfc = letraInicial;
    rfc += primeraVocal;
    rfc += inicialApellidoaterno;
    rfc += inicialNombre;
    
    //comprar con palabras prohibidas
    rfc = corregirRFC(rfc);
    
    rfc += anio;
    rfc += mes;
    rfc += dia;
    return rfc;
}

int main() {
    // envía a consola los datos que se requieren
    std::string nombre, apellidoPaterno, apellidoMaterno, fechanacimiento;
    std::cout << "Introduce tu nombre: ";
    std::getline(std::cin, nombre);
    std::transform(nombre.begin(), nombre.end(), nombre.begin(), ::toupper);
    std::cout << "Introduce tu apellido paterno: ";
    std::getline(std::cin, apellidoPaterno);
    std::transform(apellidoPaterno.begin(), apellidoPaterno.end(), apellidoPaterno.begin(), ::toupper);
    std::cout << "Introduce tu apellido materno (si no cuentas con apellido materno, presione Enter: ";
    std::getline(std::cin, apellidoMaterno);
    std::transform(apellidoMaterno.begin(), apellidoMaterno.end(), apellidoMaterno.begin(), ::toupper);
    std::cout << "Introduce la fecha de nacimiento bajo el formato DD/MM/AAAA: ";
    std::getline(std::cin, fechanacimiento);
    std::string rfc = calcularRFC(nombre, apellidoPaterno, apellidoMaterno, fechanacimiento);
    std::cout << "RFC: " << rfc << std::endl;
    
    return 0;
}