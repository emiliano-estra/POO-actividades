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
            /*Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            a) La cantidad de valores ingresados negativos.
            b) La cantidad de valores ingresados positivos.
            c) La cantidad de múltiplos de 15.
            d) El valor acumulado de los números ingresados que son pares.*/
            int negativo, positivo, multipos, acumsum, num;
            string linea;
            num = 0;
            negativo = 0;
            positivo = 0;
            multipos = 0;
            acumsum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero:");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                if (num < 0)
                {
                    negativo++;
                }
                else {
                        positivo++;
                }
                if (num % 15 == 0)
                {
                    multipos++;
                }
                if (num % 2 == 0)
                {
                    acumsum = acumsum + num;
                }
            }
            Console.WriteLine("hay " + negativo + " numeros negativo");
            Console.WriteLine("hay " + positivo + " numeros positivo");
            Console.WriteLine("hay " + multipos + " numeros multiplos de 15");
            Console.WriteLine("la suma de numero pares es: " + acumsum);
            Console.ReadKey();  


        }
    }
}
