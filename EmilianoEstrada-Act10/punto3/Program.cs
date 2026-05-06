using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class matriz
    {
        private int[,] mat;
        private int fila, columna;
        public void carga()
        {
            string linea;
            Console.WriteLine("ingrese la cantidad de filas: ");
            linea = Console.ReadLine();
            fila = int.Parse(linea);
            Console.WriteLine("ingrese la cantidad de columna: ");
            linea = Console.ReadLine();
            columna = int.Parse(linea);
            mat = new int[fila, columna];
            for (int i = 1; i < fila + 1; i++)
            {
                Console.WriteLine("fila " + i);
                for (int j = 1; j < columna + 1; j++)
                {
                    Console.Write("ingrese el numero de la columna" + j + ": ");
                    linea = Console.ReadLine();
                    mat[i - 1, j - 1] = int.Parse(linea);
                }
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    if(i==0||(i==fila-1&& j==columna-1)){
                    if (i == j||(i==fila-1&&j==columna-1))
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                    }
                    if((i==0&&j==columna-1)||(i==fila-1&&j==0)){
                        Console.Write(mat[i, j] + " ");
                    }
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {/*Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
        cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
        etc.)*/
            matriz numero = new matriz();
            numero.carga();
            numero.imprimir();
            Console.ReadKey();
        }
    }
}
