using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
            (No se ingresan valores por teclado)*/
            int num1,serie;
            Console.WriteLine("serie de 11:");
            num1 = 0;
            serie = 0;
            while (num1 != 25)
            {
                serie=serie+11;
                num1++;
                Console.WriteLine(serie);
                Console.WriteLine(num1);
            }
            Console.ReadKey();
        }
    }
}
