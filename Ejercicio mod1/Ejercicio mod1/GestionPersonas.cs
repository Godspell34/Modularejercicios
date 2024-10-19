using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio_mod1.Class1;

namespace Ejercicio_mod1
{
        public class GestionPersonas //Para gestionar lista de personas ingresadas
        {
            private Persona[] personas = new Persona[10]; //Aqui uso un arreglo para almacenar las personas 
            private int cantidadPersonas = 0;  //Se inicia el contador de las personas que se van agregando 

            public void AgregarPersona() //Metodo para agregar una nueva persona 
            {
                if (cantidadPersonas >= 10) //Aqui verificamos si no se ha alcanzado el limite de personas y si se alcanzo pues se despliega un mensaje
                {
                    Console.WriteLine("Se ha alcanzado el límite para agregar personas.");
                    return;
                }
                //Solicitmaos la info de las personas 
                Console.Write("Ingrese el nombre de la persona: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la dirección de la persona: ");
                string direccion = Console.ReadLine();

                Console.Write("Ingrese el teléfono de la persona: ");
                string telefono = Console.ReadLine();

                Console.Write("Ingrese la edad de la persona: ");
                int edad = int.Parse(Console.ReadLine());
                
                //Creamos una nueva persona y la agregamos al arreglo 
                personas[cantidadPersonas] = new Persona(nombre, direccion, telefono, edad);
                cantidadPersonas++;
            }

            public void MostrarNombres() //Este es un metodo para mostrar los nombres de las personas que se agregaron
            {
                Console.WriteLine("Lista de todos los nombres ingresados:");
            //For para iterar sobre el arreglo de personas y para poder mostrar su nombre 
                for (int i = 0; i < cantidadPersonas; i++)
                {
                    Console.WriteLine(personas[i].Nombre);
                }
            }

            //Metodo para mostrar las personas con una edad especifica
            public void MostrarPorEdad(int edad)
            {
                Console.WriteLine($"Personas con {edad} años:");
            //Repetimos el for para iterar y mostrar los datos de las personas que coinciden con la edad
                for (int i = 0; i < cantidadPersonas; i++)
                {
                    if (personas[i].Edad == edad)
                    {
                        Console.WriteLine($"{personas[i].Nombre}, {personas[i].Direccion}, {personas[i].Telefono}");
                    }
                }
            }

            public void MostrarPorNombre(string nombre)
            {
                Console.WriteLine($"Personas con nombre {nombre}:");
                for (int i = 0; i < cantidadPersonas; i++)
                {
                    if (personas[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{personas[i].Nombre}, {personas[i].Direccion}, {personas[i].Telefono}, {personas[i].Edad}");
                    }
                }
            }
        }
}

