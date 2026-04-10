using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class tres_vectores
    {
        private int[] numeros1;
        private int[] numeros2;
        private int[] valor_total;
        public void carga()
        {
            numeros1 = new int[4];
            numeros2 = new int[4];
            string linea;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("ingrese un valor al primer vector:");
                linea = Console.ReadLine();
                numeros1[i] = int.Parse(linea);
                Console.Write("ingrese un valor al segundo vector:");
                linea = Console.ReadLine();
                numeros2[i] = int.Parse(linea);
            }
        }
        public void suma_vector()
        {
            valor_total = new int[4];
            for(int i = 0;i < 4; i++)
            {
                valor_total[i]=numeros1[i]+numeros2[i];
            }
            
        }
        public void imprimir()
        {
            Console.Write("el vector es: ");
            for(int i = 0;i<4 ; i++)
            {

                Console.Write(valor_total[i]+"-");
            }
        }
        static void Main(string[] args)
        {/*Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
            elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
            tercer vector del mismo tamaño. Sumar componente a componente.*/
            tres_vectores vec=new tres_vectores();
            vec.carga();
            vec.suma_vector();
            vec.imprimir();
            Console.ReadKey();
        }
    }
}
