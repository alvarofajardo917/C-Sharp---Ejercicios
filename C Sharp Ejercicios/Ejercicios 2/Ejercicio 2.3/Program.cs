using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 3
            //Operadores Determina los operadores para verificar las siguientes condiciones:
            //Un número es mayor o igual a 18
            //Un char es ‘a’
            //Se cumplen dos conciones a la vez(ambas verdaderas)
            //Se cumple una de dos condiciones a la vez(una true y otra false)
            //Nota: puedes escribir estos datos por consola si prefieres verlos.La idea del ejercicio es almacenar los datos en los tipos más adecuados.


                // Verificar si un número es mayor o igual a 18
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                bool esMayorOIgualA18 = numero >= 18;
                Console.WriteLine("¿El número es mayor o igual a 18? " + esMayorOIgualA18);

                // Verificar si un char es 'a'
                Console.Write("Ingrese un carácter: ");
                char caracter = Console.ReadLine()[0];

                bool esCaracterA = caracter == 'a';
                Console.WriteLine("¿El carácter es 'a'? " + esCaracterA);

                // Verificar si se cumplen dos condiciones a la vez
                Console.Write("Ingrese un número mayor a 10: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese un número impar: ");
                int num2 = int.Parse(Console.ReadLine());

                bool ambasCondiciones = num1 > 10 && num2 % 2 != 0;
                Console.WriteLine("¿Se cumplen ambas condiciones? " + ambasCondiciones);

                // Verificar si se cumple una de dos condiciones a la vez
                Console.Write("Ingrese un número par: ");
                int num3 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese un número múltiplo de 5: ");
                int num4 = int.Parse(Console.ReadLine());

                bool alMenosUnaCondicion = num3 % 2 == 0 || num4 % 5 == 0;
                Console.WriteLine("¿Se cumple al menos una de las condiciones? " + alMenosUnaCondicion);
                Console.ReadKey();

        }

    }
}

