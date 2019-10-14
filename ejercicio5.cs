using System;
using System.Collections.Generic;
using System.Text;
/*Crear el programa asteriscos4 en el que se introduce un número entero y se crea una pirámide de
asteriscos. */
namespace wendyespinales2a
{
    class ejercicio5
    {
       public static void main(string[] args)
        {

            Console.WriteLine("ingrese el numero" + " de pisos de la piramide");
            string numero = Console.ReadLine();
            int numerodepisos = Convert.ToInt32(numero);
            for (int i = 1; i <= numerodepisos; i++)
            {
                for (int x = 1; x <= numerodepisos - i; x++)
                    Console.Write(" ");
                for (int x = 1; x <= 2 * i - 1; x++)
                    Console.Write("*");
                Console.WriteLine("");

            }
            Console.ReadKey();
        }
    }
}
