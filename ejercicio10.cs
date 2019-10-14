using System;
using System.Collections.Generic;
using System.Text;
/*10. Crear un programa que muestre un menú como este:
1) Salir
2) Sumatorio
3) Factorial
Tras mostrar el menú, el programa debe leer un número del 1 al tres si se elige 1, el programa acaba. Si se
elige 2 se calcula el sumatorio del número, si se elige 3 se calcula la factorial (en ambos casos el programa
pedirá escribir el número sobre el que se calcula el sumatorio o la factorial). Tras calcular el sumatorio o la
factorial e indicar el resultado, el programa volverá a mostrar el menú y así sucesivamente.*/
namespace wendyespinales2a
{
    class ejercicio10
    {
        public static void main(string[] args)
        {
            Console.WriteLine("elije una opcion/n" +
               "/n1.- salir" +
               "/n2.- sumatoria" +
               "/n3.- factorial");
            string op = null;
            op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Console.WriteLine("precione cualquier tecla");

                    break;
                case "2":
                    Console.WriteLine("ingrese un numero a ");
                    string a = Console.ReadLine();
                    int numero1 = Convert.ToInt32(a);
                    Console.WriteLine("ingrese un numero b");
                    string b = Console.ReadLine();
                    int numero2 = Convert.ToInt32(b);
                    int suma = 0;
                    suma = Convert.ToInt32(suma);
                    {
                        suma = numero1 + numero2;
                        Console.WriteLine("La sumatoria de los 2 numeros es" + suma);
                    }
                    break;
                case "3":
                    Console.WriteLine("ingrese un numero");
                    string f = Console.ReadLine();
                    int fact = Convert.ToInt32(f);
                    int tot = 1;
                    tot = Convert.ToInt32(tot);
                    for (int i = fact; i > 0; i--)
                    {
                        tot = tot * i;
                    }
                    Console.WriteLine("el factorial es" + tot);
                    break;

            }
            Console.ReadKey();

        }
    }
}