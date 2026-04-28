using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
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
            fila=int.Parse(linea);
            Console.WriteLine("ingrese la cantidad de columna: ");
            linea=Console.ReadLine();
            columna=int.Parse(linea);
            mat=new int[fila,columna];
            for(int i=1; i<fila+1; i++)
            {
                Console.WriteLine("fila "+i);
                for(int j=1; j<columna+1; j++)
                {
                    Console.Write("ingrese el numero de la columna"+j+": ");
                    linea = Console.ReadLine();
                    mat[i-1,j-1] = int.Parse(linea); 
                }
            }
        }
        public void intercambio()
        {
            int axu = 0;
            for (int i = 0; i < 1; i++) {
                for (int j = 0; j < columna; j++) {
                    axu = mat[i,j];
                    mat[i, j] = mat[i + 1, j];
                    mat[i + 1, j] = axu;
                }
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {/*Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
         primer fila con la segunda. Imprimir luego la matriz.*/
            matriz numero = new matriz();
            numero.carga();
            numero.intercambio();
            numero.imprimir();
            Console.ReadKey();
        }
    }
}
