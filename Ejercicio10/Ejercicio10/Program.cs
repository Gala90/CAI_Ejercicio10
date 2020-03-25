using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            string datos;
            string a;
            string b;
            string c;         
            string numeros = "1 2 3 4 5 6 7 8 9 0";

            Console.WriteLine("Ingrese su nombre, apellido y edad: ");
            datos = Console.ReadLine();

            string[] palabras = datos.Split(' ');

            a = palabras[0];
            b = palabras[1];
            c = palabras[2];

            if (numeros.Contains(a[0]))
            {
                Console.WriteLine("Nombre: " + b);
                Console.WriteLine("Apellido: " + c);
                Console.WriteLine("Edad: " + a);
            }
            if (numeros.Contains(b[0]))
            {
                Console.WriteLine("Nombre: " + a);
                Console.WriteLine("Apellido: " + c);
                Console.WriteLine("Edad: " + b);
            }
            if (numeros.Contains(c[0]))
            {
                Console.WriteLine("Nombre: " + a);
                Console.WriteLine("Apellido: " + b);
                Console.WriteLine("Edad: " + c);
            }
         
            Console.ReadKey();

        }
    }
}
