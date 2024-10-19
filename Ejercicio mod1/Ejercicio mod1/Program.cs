using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_mod1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GestionPersonas gestion = new GestionPersonas(); 
            int opcion; 

            do
            {
                // ╚ ╔ ╦ ╠ ═ ╬ ╣ ║ ╗ ╝ ╩ 
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                              * MENÚ *                              ║");
                Console.WriteLine("╠═════════════════════════════════╦══════════════════════════════════╣");
                Console.WriteLine("║  1. Agregar persona             ║  2. Mostrar todos los nombres    ║");
                Console.WriteLine("╠═════════════════════════════════╬══════════════════════════════════╣");
                Console.WriteLine("║  3. Mostrar personas por edad   ║  4. Mostrar personas por nombre  ║");
                Console.WriteLine("╠═════════════════════════════════╩══════════════════════════════════╣");
                Console.WriteLine("║                             5. Salir                               ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝");
                Console.Write("Selecciona la opción a seguir: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        gestion.AgregarPersona();
                        break;
                    case 2:
                        gestion.MostrarNombres();
                        break;
                    case 3:
                        Console.Write("Ingrese la edad que desea buscar: ");
                        int edad = int.Parse(Console.ReadLine());
                        gestion.MostrarPorEdad(edad);
                        break;
                    case 4:
                        Console.Write("Ingrese el nombre que desea buscar: ");
                        string nombre = Console.ReadLine();
                        gestion.MostrarPorNombre(nombre);
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 5);
        }
    }
}