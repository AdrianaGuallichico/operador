using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("operadores logicos");

            string genero;
            int edad;
            Console.Write("INGRESE TU GENERO (H-M): ");
            genero = Console.ReadLine();

            Console.Write("INGRESE TU EDAD: ");
            edad =Int32.Parse(Console.ReadLine());

            string nombre;
            Console.Write("ingresa tu nombre: ");
            nombre = Console.ReadLine();

            if (edad >= 18 && genero == "M")
                Console.WriteLine($"hola señorita{nombre}eres mayor de edad y tienes {edad}años");

            else if (edad < 18 && genero == "M")

                Console.WriteLine($"hola niña {nombre}eres menor de edad y tienes {edad}años");

	    if (!(edad >= 16 && edad <= 60))
            {
                Console.WriteLine("Tu edad no está entre 16 y 60 años, por lo tanto no puedes votar");
            }
            else
            {
                Console.WriteLine("Si puedes votar en las elecciones del 2023");
            }

            Console.ReadKey();

        }
    }
}
