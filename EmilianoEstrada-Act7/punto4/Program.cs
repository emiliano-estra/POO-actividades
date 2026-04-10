using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class mayor_menor
    {
        private int[] orden;
        public void cargar()
        {
            orden = new int[10];
            string linea;
            for (int i = 0; i < orden.Length; i++)
            {
                Console.Write("ingrese un valor al vector: ");
                linea = Console.ReadLine();
                orden[i]=int.Parse(linea);
            }
        }
        public void imprimir()
        {
            bool mayor_menor,menor_mayor;
            mayor_menor = false;
            menor_mayor = false;
            mayor_menor = orden_mayor_menor();
            menor_mayor = orden_menor_mayor();
            if (mayor_menor) {
                Console.WriteLine("esta ordenado de mayor a menor");
            }
            else if(menor_mayor)
            {
                Console.WriteLine("esta ordenado de menor a mayor");
            }
            else { Console.Write("esta mal"); }
        }
        public bool orden_mayor_menor()
        {
            bool es_mayor;
            int cant;
            es_mayor = false;
            cant = 0;
            for (int i = 0; i < orden.Length; i++) {
                if (i < orden.Length-1)
                {
                    if (orden[i] > orden[i + 1 ]) {
                        cant++;
               
                    }
                }
            }
            if (cant == 9) { 
            es_mayor=true;
            }
            return es_mayor;
        }
        public bool orden_menor_mayor()
        {
            bool es_menor;
            int cant;
            es_menor = false;
            cant = 0;
            for (int i = 0; i < orden.Length; i++)
            {
                if ( i < orden.Length-1)
                {
                    if (orden[i] < orden[i + 1])
                    {
                        cant++;
                    }
                }

            }
            if (cant == 9)
            {
                es_menor = true;
            }
            return es_menor;
        }
        static void Main(string[] args)
        {
            /*Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
            ordenado de menor a mayor y de mayor a menor.*/
            mayor_menor ordenado=new mayor_menor();
            ordenado.cargar();
            ordenado.imprimir();
            Console.ReadKey();
        }
    }
}
