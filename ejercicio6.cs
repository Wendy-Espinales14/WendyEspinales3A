using System;
using System.Collections.Generic;
using System.Text;
/*6. Modificar el ejercicio anterior para que aparezca un rombo*/
namespace wendyespinales2a
{
    class ejercicio6
    {
        static void main(string[] args)
        {

            {


                Console.WriteLine(" Ingrese un numero para el rombo");
                string num = Console.ReadLine();
                int nu = Convert.ToInt32(num);
                for (int j = 0; j < nu; ++j)
                {
                    for (int i = 0; i < nu - j - 1; ++i)
                        Console.Write(" ");
                    for (int i = 0; i < 2 * j + 1; ++i)
                        Console.Write("*");
                    Console.WriteLine();
                }

                for (int j = nu - 2; j >= 0; --j)
                {
                    for (int i = 0; i < nu - j - 1; ++i)
                        Console.Write(" ");
                    for (int i = 0; i < 2 * j + 1; ++i)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        
    }
}
