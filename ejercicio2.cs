using System;
using System.Collections.Generic;
using System.Text;

namespace wendyespinales2a
{
    class ejercicio2
    {
        public static void main (string[]args)
        {
            Console.Write("ingrese el numero del tamaño que sea el cuadrado");
            string numero = Console.ReadLine();
        int n = Convert.ToInt32(numero);
            if (n >= 0 && n <= 50)
            {
                for (int i = 0; i<n; i++)
                {
                    Console.Write(" *");
                }
    Console.WriteLine("  ");
                for (int i = 0; i<n - 2; i++)
                {
                    Console.Write(" *");
                    for (int w = 0; w<n - 2; w++)
                    {
                        Console.Write("  ");
                    }
Console.WriteLine(" *");

                }
                for (int i = 0; i<n; i++)
                {
                    Console.Write(" *");
                }
            }
        }
    }
    
}
