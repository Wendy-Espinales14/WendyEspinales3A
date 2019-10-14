using System;
using System.Collections.Generic;
using System.Text;

namespace wendyespinales2a
{
    class ejercicio3
    {
        public static void main(string[] args)
        {
            int cant = 0;
        double precio = 0, sum = 0, total = 0;
        Console.WriteLine("recordatorio: una vez que termine de ingresar" +
                "las cantidades de los productos y quiera saber el total ingresar 0");
            do{
                Console.WriteLine("ingrese cantidad");
                cant = int.Parse(Console.ReadLine());
                if (cant > 0)
                {
                    Console.WriteLine("ingrese precio");
                    precio = double.Parse(Console.ReadLine());
                      total = cant* precio;
                       sum = sum + total;
                }
             } while (cant != 0);
            Console.Write("el total de la factura es" + sum);
            Console.ReadKey();
        }

    }
    
}
