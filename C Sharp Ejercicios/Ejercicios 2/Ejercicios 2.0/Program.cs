using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            //Variables Escribe un programa que reciba datos de una persona y genera
            //    un mensaje, usa una variable para cada dato y otra para el mensaje. 
            //    Ej: nombre, apellido, edad, sabe programar, etc.

                // Solicitar datos de la persona
                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese su apellido: ");
                string apellido = Console.ReadLine();

                Console.Write("Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("¿Sabe programar? (Si/No): ");
                string sabeProgramar = Console.ReadLine();

                // Generar el mensaje utilizando variables
                string mensaje = "Hola, mi nombre es " + nombre + " " + apellido + ".";
                mensaje += " Tengo " + edad + " años.";

                if (sabeProgramar.ToLower() == "si")
                {
                    mensaje += " Sé programar.";
                }
                else
                {
                    mensaje += " No sé programar.";
                }

                // Imprimir el mensaje generado
                Console.WriteLine(mensaje);
                Console.ReadKey();
        }
    }

}

