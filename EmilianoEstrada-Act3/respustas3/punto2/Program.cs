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
            /*Se ingresan tres valores por teclado, si todos son iguales se imprime la suma
            del primero con el segundo y a este resultado se lo multiplica por el tercero.*/
            int num1,num2,num3,suma,producto;
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

            if (num1==num2)
            {
                if (num2 == num3) {
                    suma = num1 + num2;
                    Console.WriteLine("la suma es:" + suma);
                    producto = suma * num3;
                    Console.WriteLine("la multiplicacion es:" + producto);
                }
            }
            Console.ReadKey();
        }
    }
}
