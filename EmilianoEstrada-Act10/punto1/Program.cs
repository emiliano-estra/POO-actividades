using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class matriz
    {
        private int[,] mat;
        public void carga()
        {
            mat = new int[2, 5];
            string linea;
            for (int i = 1; i < 6; i++) {
                Console.WriteLine("columna numero "+i);
                for (int j = 0; j < 2; j++) {
                    Console.Write("ingrese el numero para la fila: ");
                    linea = Console.ReadLine();
                    mat[j,i-1]=int.Parse(linea);
                }
            }
            
        }
        public void imprimir() {
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write(mat[i,j]+" ");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {/*Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
        componentes por columna (es decir primero ingresar toda la primer
        columna, luego la segunda columna y así sucesivamente)
        Imprimir luego la matriz.*/
            matriz matriz = new matriz();
            matriz.carga();
            matriz.imprimir();
            Console.ReadKey();
        }
    }
}
