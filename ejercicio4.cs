using System;
using System.Collections.Generic;
using System.Text;
/* Crear un programa para calcular el salario semanal de unos empleados a los que se les paga 15 dólares
por hora si éstas no superan las 35 horas. Cada hora por encima de 35 se considerará extra y se paga a
22 dólares.
El programa pide las horas del trabajador y devuelve el salario que se le debe pagar
Además, el programa debe preguntar si deseamos calcular otro salario, si es así el programa se repite.*/

namespace wendyespinales2a
{
    class ejercicio4
    {
        public static void main (string[]args)
        {

            int horas, horasextra, resp;
            double salario, salarioextra, salariototal;
            do
            {
                Console.WriteLine("ingrese las horas trabajadas del empleado");
                horas = int.Parse(Console.ReadLine());
                if (horas <= 35)
                {
                    salario = horas * 15;

                }
                else
                {
                    horasextra = horas - 35;
                    salarioextra = horasextra * 22;
                    salariototal = 35 * 15;
                    salario = salarioextra + salariototal;
                }
                Console.WriteLine(" el sueldo total es:" + salario);
                Console.WriteLine("desea calcular el salario de otra persona? si su respuesta es si presione 1 si no presione 0");
                resp = int.Parse(Console.ReadLine());
            } while (resp == 1);
            Console.WriteLine("fin de ingreso de salarios");
            Console.ReadKey();
        }
    }
}
