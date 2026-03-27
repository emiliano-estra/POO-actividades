using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que acumule(sume) valores ingresados por teclado hasta
ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.*/
            int suma,num1;
            string linea;
            Boolean corte=true;
            num1= 0;
            suma= 0;

            while (corte)
            {
                Console.WriteLine("ingresa un numero (9999 corta el programa) :");
                linea = Console.ReadLine();
                num1 = int.Parse(linea);
                if (num1 == 9999) { 
                corte=false;
                }
                else { 
                    suma = suma + num1; 
                }
            }
            Console.WriteLine("el valor acumulado es:"+suma);
            if (suma == 0) {
                Console.WriteLine("la suma es igual a cero");
            }
            else if (suma > 0) {
                Console.WriteLine("la suma es mayor a cero");
            }
            else { 
                Console.WriteLine("la suma es menor a cero");
            }
            Console.ReadKey();
        }
    }
}
