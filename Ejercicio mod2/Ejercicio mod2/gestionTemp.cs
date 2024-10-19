using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_mod2
{
    internal class gestionTemp
    {
        // Listas para almacenar las temperaturas
        private List<double> temperaturasCelsius = new List<double>();
        private List<double> temperaturasFahrenheit = new List<double>();
        private List<double> temperaturasKelvin = new List<double>();

        // Método para agregar una temperatura en Celsius
        public void AgregarTemperatura(double celsius)
        {
            temperaturasCelsius.Add(celsius);
            Console.WriteLine($"Temperatura {celsius}°C agregada correctamente.");
        }

        // Método para convertir las temperaturas a Fahrenheit
        public void ConvertirAFahrenheit()
        {
            foreach (var temp in temperaturasCelsius)
            {
                double fahrenheit = (temp * 9 / 5) + 32;
                temperaturasFahrenheit.Add(fahrenheit);
            }
            Console.WriteLine("Las temperaturas han sido convertidas a Fahrenheit.");
        }

        // Método para convertir las temperaturas a Kelvin
        public void ConvertirAKelvin()
        {
            foreach (var temp in temperaturasCelsius)
            {
                double kelvin = temp + 273.15;
                temperaturasKelvin.Add(kelvin);
            }
            Console.WriteLine("Las temperaturas han sido convertidas a Kelvin.");
        }

        // Método para mostrar las temperaturas convertidas
        public void MostrarTemperaturasConvertidas()
        {
            Console.WriteLine("Temperaturas en Fahrenheit:");
            foreach (var temp in temperaturasFahrenheit)
            {
                Console.WriteLine($"{temp}°F");
            }

            Console.WriteLine("Temperaturas en Kelvin:");
            foreach (var temp in temperaturasKelvin)
            {
                Console.WriteLine($"{temp}K");
            }
        }

        // Método para eliminar una temperatura de la lista de Fahrenheit o Kelvin
        public void EliminarTemperaturaConvertida(string tipo, double valor)
        {
            if (tipo.ToLower() == "fahrenheit")
            {
                if (temperaturasFahrenheit.Remove(valor))
                {
                    Console.WriteLine($"Temperatura {valor}°F eliminada de la lista.");
                }
                else
                {
                    Console.WriteLine($"Temperatura {valor}°F no encontrada.");
                }
            }
            else if (tipo.ToLower() == "kelvin")
            {
                if (temperaturasKelvin.Remove(valor))
                {
                    Console.WriteLine($"Temperatura {valor}K eliminada de la lista.");
                }
                else
                {
                    Console.WriteLine($"Temperatura {valor}K no encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Tipo de temperatura no válido. Use 'fahrenheit' o 'kelvin'.");
            }
        }
    }
}

