using System;
using System.Collections.Generic;
using System.Text;
/*Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15.*/
namespace wendyespinales2a
{
    class ejercicio9
    {
        public static void main(string[] args)
        {
            {
                Console.WriteLine("escriba el numero de la tabla de multiplicar que necesite");
                string numero = Console.ReadLine();
                int numerotabla = Convert.ToInt32(numero);

                for (int i = 1; i <= 15; i++)
                {

                    Console.WriteLine("{0}x{1}={2}", numero, i, numerotabla * i);
                }
                Console.ReadKey();
            }
        }
    }
}
