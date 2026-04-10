using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class vectorn
    {
        private int[] vector;
        private int menor;
        public void cargar()
        {
            int cant;
            string linea;
            menor = 0;
            Console.Write("ingrese el largo del vector: ");
            linea = Console.ReadLine();
            cant=int.Parse(linea);
            vector=new int[cant];
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write("ingrese valores al vector: ");
                linea=Console.ReadLine();
                vector[i] = int.Parse(linea);
                if(i == 0)
                {
                    menor = vector[0];
                }
                if (menor == vector[i] && i!=0)
                {
                    Console.WriteLine("repetiste el numero menor");
                }
                if (menor > vector[i])
                {
                    menor = vector[i];
                }
                
            }
        }
        public void imprimir()
        {
            Console.WriteLine("el numero menor es: "+menor);
        }
        static void Main(string[] args)
        {
            /*Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
            del vector.*/
            vectorn ventor=new vectorn();
            ventor.cargar();
            ventor.imprimir();
        }
    }
}
