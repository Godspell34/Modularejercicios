using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_mod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gestionTemp gestion = new gestionTemp();
            bool continuar = true;

            while (continuar)
            {
                // ╚ ╔ ╦ ╠ ═ ╬ ╣ ║ ╗ ╝ ╩ 
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                    * MENÚ *                                     ║");
                Console.WriteLine("╠═══════════════════════════════════════╦═════════════════════════════════════════╣");
                Console.WriteLine("║  1. Agregar temperatura en Celsius    ║  2. Convertir temperaturas a Fahrenheit ║");
                Console.WriteLine("╠═══════════════════════════════════════╬═════════════════════════════════════════╣");
                Console.WriteLine("║  3. Convertir temperaturas a Kelvin   ║  4. Mostrar temperaturas convertidas    ║");
                Console.WriteLine("╠═══════════════════════════════════════╬═════════════════════════════════════════╣");
                Console.WriteLine("║  5. Eliminar temperatura convertida   ║  6. Salir                               ║");
                Console.WriteLine("╚═══════════════════════════════════════╩═════════════════════════════════════════╝");
                Console.Write("Selecciona la opción a seguir: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese una temperatura en grados Celsius: ");
                        double tempCelsius = double.Parse(Console.ReadLine());
                        gestion.AgregarTemperatura(tempCelsius);
                        break;

                    case 2:
                        gestion.ConvertirAFahrenheit();
                        break;

                    case 3:
                        gestion.ConvertirAKelvin();
                        break;

                    case 4:
                        gestion.MostrarTemperaturasConvertidas();
                        break;

                    case 5:
                        Console.Write("¿De qué lista desea eliminar la temperatura (fahrenheit/kelvin)?: ");
                        string tipo = Console.ReadLine();
                        Console.Write($"Ingrese la temperatura a eliminar en {tipo}: ");
                        double valor = double.Parse(Console.ReadLine());
                        gestion.EliminarTemperaturaConvertida(tipo, valor);
                        break;

                    case 6:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
