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
            // Crear una lista para almacenar números y sus factoriales
            List<NumeroFactorial> numerosFactoriales = new List<NumeroFactorial>();

            // Crear una instancia de la clase Calculadora
            Class1 calculadora = new Class1();

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

                // Almacenar el número y su factorial en la lista
                if (numero > 0)
                {
                    NumeroFactorial nf = new NumeroFactorial
                    {
                        Numero = numero,
                        Factorial = calculadora.CalcularFactorial(numero)
                    };
                    numerosFactoriales.Add(nf);
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
            foreach (var item in numerosFactoriales)
            {
                Console.WriteLine($"Número: {item.Numero}, Factorial: {item.Factorial:e}");
            }
        }
    }
}
