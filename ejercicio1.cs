using System;
/* . Programa que lea una serie de números por teclado e indique cuál es el mayor */
namespace wendyespinales2a
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero para"+"generar una serie de numeros y mostrar el mayor");
            string numero1 = Console.ReadLine();
            int entero1 = Convert.ToInt16(numero1);
            int mayor = 0;
            mayor = Convert.ToInt32(mayor);
            for(int i=1;i<=entero1;i++)
            {
                Console.WriteLine("ingrese numero");
                string numero = Console.ReadLine();
                int valor = Convert.ToInt32(numero);
            
            if (valor > mayor){
                    mayor = valor;
                }
            }
            Console.WriteLine("el numero mayor es:" + mayor);
            
            Console.ReadKey();
        }
    }
}
