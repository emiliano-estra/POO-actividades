using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class vector
    {
        private int[] numeros;
        public void carga()
        {
            numeros=new int[8];
            string linea;
            for(int i = 0; i < 8; i++)
            {
                Console.Write("ingrese ocho valores:");
                linea = Console.ReadLine();
                numeros[i] = int.Parse(linea);
            }
        }
        public void calcular_valores() {
            int suma,suma_mayor_36,cant_mayor_50;
            suma = 0;
            suma_mayor_36 = 0;
            cant_mayor_50 = 0;
            for (int i = 0; i < 8; i++)
            {
                suma=suma+numeros[i];
                if (numeros[i] > 36)
                {
                    suma_mayor_36=suma_mayor_36+numeros[i];
                    if(numeros[i] > 50)
                    {
                        cant_mayor_50++;
                    }
                }
            }
            Console.WriteLine("el valor acumulado de todo el vector es: "+suma);
            Console.WriteLine("el valor acumulado de los numeros mayores a 36 es: "+suma_mayor_36);
            Console.WriteLine("hay " + cant_mayor_50 + " numeros mayores a 50");
        }
        static void Main(string[] args)
        {
            /*Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
            El valor acumulado de todos los elementos del vector.
            El valor acumulado de los elementos del vector que sean mayores a 36.
            Cantidad de valores mayores a 50.*/
            vector vec=new vector();
            vec.carga();
            vec.calcular_valores();
            Console.ReadKey();
        }
    }
}
