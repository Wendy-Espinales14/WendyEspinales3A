using System;
using System.Collections.Generic;
using System.Text;
/*Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas. La primera
cuenta desde uno hasta el número escrito contando de uno en uno; la segunda columna cuenta de dos
en dos y la tercera de tres. */
namespace wendyespinales2a
{
    class ejercicio8
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i <= n / 2)
                {
                    Console.Write("      " + (i + i));

                }
                else
                {
                    Console.Write(" ");
                }
                if (i <= n / 3)
                {
                    Console.WriteLine("      " + (i + i + i));

                }
                else
                {
                    Console.WriteLine(" ");
                }

            }
            Console.ReadKey();
                }
            }
}
        