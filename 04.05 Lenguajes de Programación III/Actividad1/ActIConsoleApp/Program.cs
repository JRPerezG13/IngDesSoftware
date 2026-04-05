using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActIConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string nombre;
            string edad;
            string fecnac;
            string carrera;

            //Mensaje de bienvenida
            Console.WriteLine("Bienvenidos a Universidad Coppel");
            Console.WriteLine("---------------------------------");
            //Captura de datos
            Console.WriteLine("\nIngresa los datos solicitados");
            
            Console.WriteLine("\nNombre completo:");
            nombre = Console.ReadLine();
            
            Console.WriteLine("\nEdad:");
            edad = Console.ReadLine();
            
            Console.WriteLine("\nFecha de nacimiento (DD-MM-AAAA):");
            fecnac = Console.ReadLine();
            
            Console.WriteLine("\nCarrera a la que desea ingresar:");
            carrera = Console.ReadLine();

            //Mensaje de salida
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\n\nGracias " + nombre + " por fomar parte de Universidad Coppel. \nTe damos la bienvenida a la carrera " + carrera + "!!!");
            Console.WriteLine("\nNombre: " + nombre);
            Console.WriteLine("\nEdad: " + edad);
            Console.WriteLine("\nFecha de nacimiento: " + fecnac);
            Console.WriteLine("Carrera asignada: " + carrera);

            Console.WriteLine("\n\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
