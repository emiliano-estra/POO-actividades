using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class VectorM
    {
        private int[] numeros;
        public void carga()
        {
            string linea;
            int n;
            Console.Write("ingrese el largo del vector: ");
            linea= Console.ReadLine();
            n=int.Parse(linea);
            numeros=new int[n];
            for (int i=0; i < numeros.Length; i++)
            {
                Console.Write("ingrese los numeros del vector: ");
                linea = Console.ReadLine();
                numeros[i]=int.Parse(linea);
            }
        }
        public void ordenar() {
           
            for (int r = 0; r < numeros.Length; r++) {
                for (int c = 0; c < numeros.Length-r ; c++) {
                    if (c != numeros.Length-1)
                    {
                        if (numeros[c] > numeros[c + 1])
                        {
                            int aux_num;
                            aux_num = numeros[c];
                            numeros[c] = numeros[c + 1];
                            numeros[c + 1] = aux_num;
                        }
                    }
                }
            }
        }
        public void imprimir()
        {
            Console.WriteLine("estan ordenados de menor a mayor: ");
            for (int r = 0; r < numeros.Length; r++)
            {
                Console.Write(numeros[r]+",");
            }
        }
        static void Main(string[] args)
        {
            /*Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
            (el orden lo pueden elegir ustedes).*/
            VectorM vector = new VectorM();
            vector.carga();
            vector.ordenar();
            vector.imprimir();
            Console.ReadKey();
        }
    }
}
