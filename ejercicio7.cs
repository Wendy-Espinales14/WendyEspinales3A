using System;
using System.Collections.Generic;
using System.Text;
/*Crear un programa que escriba dos columnas de números, en la primera se colocan los números del 1 al
100, en la segunda los números del 100 al 1 */
namespace wendyespinales2a
{
    class ejercicio7
    {
        static void main(string[] args)
        {
            {
                int valores = 0;
                int valores2 = 101;
                valores = Convert.ToInt32(valores);
                valores2 = Convert.ToInt32(valores2);
                while (valores < 100)
                {


                    valores = valores + 1;
                    valores2 = valores2 - 1;
                    Console.WriteLine("{0} -------- {1}", valores, valores2);
                }
                Console.ReadKey();
            }
        }

    
}
 }
       