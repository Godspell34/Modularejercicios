using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Factorial_Modular
{
    internal class Class1
    {
        // Estructura para almacenar el número y su factorial
        public struct NumeroFactorial
        {
            public int Numero;
            public double Factorial;

        }

        // Clase que contiene el método para calcular el factorial
        public class Calculadora
        {
            // Método que calcula el factorial de un número
            public double CalcularFactorial(int numero)
            {
                if (numero < 0)
                {
                    throw new ArgumentException("No se puede calcular el factorial de números negativos.");
                }

                double factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}
