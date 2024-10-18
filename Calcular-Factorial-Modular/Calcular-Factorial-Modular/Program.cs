using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calcular_Factorial_Modular.Class1;

namespace Calcular_Factorial_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir el tamaño del arreglo
            const int tamañoArreglo = 10;
            NumeroFactorial[] numerosFactoriales = new NumeroFactorial[tamañoArreglo];
            int contador = 0;

            // Crear una instancia de la clase Calculadora
            Calculadora calculadora = new Calculadora();

            // Bucle para solicitar números al usuario
            while (true)
            {
                Console.Write("Ingrese un número positivo (o 0 para terminar): ");
                int numero = Convert.ToInt32(Console.ReadLine());

                // Condición para terminar el bucle
                if (numero < 0)
                {
                    Console.WriteLine("Por favor, ingrese solo números positivos o cero.");
                    continue;
                }

                // Almacenar el número y su factorial en el arreglo
                if (contador < tamañoArreglo)
                {
                    numerosFactoriales[contador].Numero = numero;
                    numerosFactoriales[contador].Factorial = calculadora.CalcularFactorial(numero);
                    contador++;
                }
                else
                {
                    Console.WriteLine("Se ha alcanzado el límite de números.");
                    break;
                }

                // Preguntar al usuario si desea continuar
                Console.Write("¿Desea ingresar otro número? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta != "s")
                {
                    break;
                }
            }

            // Mostrar los resultados
            Console.WriteLine("\nNúmeros ingresados y sus factoriales:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Número: {numerosFactoriales[i].Numero}, Factorial: {numerosFactoriales[i].Factorial:e}");
            }
        }
    }
}
