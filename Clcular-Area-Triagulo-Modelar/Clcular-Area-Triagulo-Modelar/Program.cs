using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clcular_Area_Triagulo_Modelar.Class1;

namespace Clcular_Area_Triagulo_Modelar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Calculadora
            Calculadora calculadora = new Calculadora();

            // Solicitar al usuario la base y la altura del triángulo
            Console.Write("Ingrese la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // Calcular el área utilizando el método de la clase Calculadora
            double area = calculadora.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);

            // Mostrar el resultado
            Console.WriteLine($"El área del triángulo es: {area}");
        }
    }
}
