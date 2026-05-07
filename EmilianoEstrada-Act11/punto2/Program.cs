using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class matriz_irregular
    {
        private int[][] matriz;
        public void carga()
        {
            matriz = new int[5][];
            string linea;
            for(int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[i+1];
            }
            for(int i = 0;i < matriz.Length; i++)
            {
                Console.WriteLine("fila " + i);
                for(int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write("ingrese el valor de la columna" + i + ": ");
                    linea=Console.ReadLine();
                    matriz[i][j]=int.Parse(linea);
                }
            }
        }
        public void imprimir() {
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write(matriz[i][j]);
                    
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {/*Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
        primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
        (crearla sin la intervención del operador)
        Realizar la carga por teclado e imprimir posteriormente.*/
            matriz_irregular mat=new matriz_irregular();
            mat.carga();
            mat.imprimir();
            Console.ReadKey();
        }
    }
}
