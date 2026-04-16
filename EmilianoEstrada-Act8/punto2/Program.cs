using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Paises
    {
        private string[] paises;
        public void carga()
        {
            paises = new string[5];
            string linea;
            for(int i = 0; i < 5; i++) {
                Console.Write("ingrese cinco paises: ");
                linea = Console.ReadLine();
                paises[i] = linea;
            }
        }
        public void orden_alfabético()
        {
            for (int i = 0; i<5; i++)
            {
                for(int a=0; a<5-i; a++){
                    if (a != 4)
                    {
                        if (paises[a].CompareTo(paises[a + 1]) > 0)
                        {
                            string aux = paises[a];
                            paises[a] = paises[a + 1];
                            paises[a + 1] = aux;

                        }
                    } 
                }
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(paises[i]+", ");
            }
        }
        static void Main(string[] args)
        {
            /*Definir un vector donde almacenar los nombres de 5 países.Confeccionar el
            algoritmo de ordenamiento alfabético.*/
            Paises paises = new Paises();
            paises.carga();
            paises.orden_alfabético();
            paises.imprimir();
            Console.ReadKey();
        }
    }
}
