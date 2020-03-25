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
            string[] nombres = { "Martin", "Agustina", "Santiago", "Karen", "Gala" };
            string[] apellidos = { "Rodriguez", "Palacios", "Ramos", "Fernandez", "Magdalena" };
            string[] edades = { "22", "24", "25", "27", "29" };
            string datos;
            string a;
            string b;
            string c;
            string nombre = "";
            string apellido = "";
            string edad = "";
           

            Console.WriteLine("Ingrese su nombre, apellido y edad: ");
            datos = Console.ReadLine();

            string[] palabras = datos.Split(' ');

            a = palabras[0];
            b = palabras[1];
            c = palabras[2];

            if (nombres.Contains(a))
            {
                nombre = a;
            }
            if (apellidos.Contains(a))
            {
               apellido = a;
            }
            if (edades.Contains(a))
            {
                edad = a;
            }

            if (nombres.Contains(b))
            {
                nombre = b;
            }
            if (apellidos.Contains(b))
            {
                apellido = b;
            }
            if (edades.Contains(b))
            {
                edad = b;
            }

            if (nombres.Contains(c))
            {
                nombre = c;
            }
            if (apellidos.Contains(c))
            {
                apellido = c;
            }
            if (edades.Contains(c))
            {
                edad = c;
            }


            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);


            Console.ReadKey();



        }
    }
}
