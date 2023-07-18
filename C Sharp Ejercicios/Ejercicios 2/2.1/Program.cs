using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 2
            //Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
            //Coche: puertas, ruedas, marca, ITV vigente
            //Mesa: peso, largo, material, color
            //Nota: puedes escribir estos datos por consola si prefieres verlos.La idea del ejercicio es almacenar los datos en los tipos más adecuados.

                // Datos del coche
                Console.WriteLine("Ingrese los datos del coche:");

                Console.Write("Número de puertas: ");
                int puertas = int.Parse(Console.ReadLine());

                Console.Write("Número de ruedas: ");
                int ruedas = int.Parse(Console.ReadLine());

                Console.Write("Marca: ");
                string marca = Console.ReadLine();

                Console.Write("¿ITV vigente? (true/false): ");
                bool itvVigente = bool.Parse(Console.ReadLine());

                // Datos de la mesa
                Console.WriteLine("Ingrese los datos de la mesa:");

                Console.Write("Peso: ");
                double peso = double.Parse(Console.ReadLine());

                Console.Write("Largo: ");
                double largo = double.Parse(Console.ReadLine());    

                Console.Write("Material: ");
                string material = Console.ReadLine();

                Console.Write("Color: ");
                string color = Console.ReadLine();

                // Imprimir los datos almacenados
                Console.WriteLine("\nDatos del coche:");
                Console.WriteLine("Número de puertas: " + puertas);
                Console.WriteLine("Número de ruedas: " + ruedas);
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("ITV vigente: " + itvVigente);

                Console.WriteLine("\nDatos de la mesa:");
                Console.WriteLine("Peso: " + peso);
                Console.WriteLine("Largo: " + largo);
                Console.ReadKey();


        }

    }
}
