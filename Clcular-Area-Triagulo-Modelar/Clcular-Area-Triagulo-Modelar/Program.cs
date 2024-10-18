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
            Class1 calculadora = new Class1();

            // Solicitar al usuario la cantidad de triángulos
            Console.Write("Ingrese la cantidad de triángulos: ");
            int cantidadTriangulos = Convert.ToInt32(Console.ReadLine());

            // Crear listas para almacenar las bases y alturas
            List<double> bases = new List<double>();
            List<double> alturas = new List<double>();

            // Solicitar la base y altura para cada triángulo
            for (int i = 0; i < cantidadTriangulos; i++)
            {
                Console.Write($"Ingrese la base del triángulo {i + 1}: ");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                bases.Add(baseTriangulo);

                Console.Write($"Ingrese la altura del triángulo {i + 1}: ");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                alturas.Add(alturaTriangulo);
            }

            // Calcular y mostrar el área de cada triángulo
            for (int i = 0; i < cantidadTriangulos; i++)
            {
                double area = calculadora.CalcularAreaTriangulo(bases[i], alturas[i]);
                Console.WriteLine($"El área del triángulo {i + 1} es: {area}");
            }
        }
    }

}
