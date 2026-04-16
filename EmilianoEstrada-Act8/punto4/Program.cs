using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Orden
    {
        private string[] pais;
        private int[] habitantes;
        public void carga()
        {
            pais = new string[5];
            habitantes = new int[5];
            string linea;
            for (int i = 0; i < 5; i++) {
                Console.Write("ingrese un nombre de un pais: ");
                pais[i]=Console.ReadLine();
                Console.Write("ingrese los habitantes: ");
                linea = Console.ReadLine();
                habitantes[i]=int.Parse(linea);
            }
        }
        public void imprimir()
        {
            orden_alfabetico();
            Console.WriteLine("este es el orden alfabetico: ");
            for (int i = 0; i < 5; i++) {
                Console.Write(pais[i]);
                Console.WriteLine(habitantes[i]);
            }
            orden_cantidad_habitantes();
            Console.WriteLine("este es el orden cantidad de habitantes: ");
            for (int i = 0; i < 5; i++) {
                Console.Write(pais[i]);
                Console.WriteLine(habitantes[i]);
            }
        }
        public void orden_alfabetico()
        {
            for (int r = 0; r < pais.Length; r++)
            {
                for (int c = 0; c < pais.Length - r; c++)
                {
                    if (c != pais.Length - 1)
                    {
                        if (pais[c].CompareTo(pais[c + 1]) > 0)
                        {
                            string aux;
                            int aux_num;
                            aux = pais[c];
                            pais[c] = pais[c + 1];
                            pais[c + 1] = aux;
                            aux_num = habitantes[c];
                            habitantes[c] = habitantes[c + 1];
                            habitantes[c+1]=aux_num;
                        }
                    }
                }
            }
        }
        public void orden_cantidad_habitantes()
        {
            for (int r = 0; r < habitantes.Length; r++)
            {
                for (int c = 0; c < habitantes.Length - r; c++)
                {
                    if (c != habitantes.Length - 1)
                    {
                        if (habitantes[c] < habitantes[c + 1])
                        {
                            string aux;
                            int aux_num;
                            aux = pais[c];
                            pais[c] = pais[c + 1];
                            pais[c + 1] = aux;
                            aux_num = habitantes[c];
                            habitantes[c] = habitantes[c + 1];
                            habitantes[c + 1] = aux_num;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            /*Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
            habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
            ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
            nuevamente.*/
            Orden pais=new Orden();
            pais.carga();
            pais.imprimir();
            Console.ReadKey();
        }
    }
}
