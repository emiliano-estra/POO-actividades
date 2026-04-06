using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, 
            imprimir en pantalla la leyenda "Todos los números son menores a diez"*/
            int num1, num2, num3;
            string linea;
            Console.Write("ingrese un numero:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese otro numero:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("ingrese otro numero:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 < 10 && num2 < 10 && num3 < 10)
            { 
                    Console.Write("Todos los numeros son menores a 10");
            }
            Console.ReadKey();
        }
    }
}
