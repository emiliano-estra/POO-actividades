using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class venta
    {
        private string[] vendedor;
        private int[] ventatotal;
        public void cargar()
        {
            vendedor=new string[5];
            ventatotal=new int[5];
            string linea;
            for(int i = 0; i < 5; i++)
            {
                Console.Write("ingrese el nombre del vendedor: ");
                linea = Console.ReadLine();
                vendedor[i] = linea;
                Console.Write("ingrese las ventas totales del vendedor: ");
                linea=Console.ReadLine();
                ventatotal[i]=int.Parse(linea);
            }
           
        }
        public void orden()
        {
            int aux;
            string aux_nombre;
            for (int i = 0; i < vendedor.Length; i++) {
                for (int j = 0; j < vendedor.Length; j++) {
                    if (j != vendedor.Length - 1)
                    {
                        if (ventatotal[i] < ventatotal[i+1])
                        {
                            aux = ventatotal[j];
                            ventatotal[j] = ventatotal[j + 1];
                            ventatotal[j + 1] = aux;
                            aux_nombre = vendedor[j];
                            vendedor[j] = vendedor[j + 1];
                            vendedor[j + 1] = aux_nombre;
                        }
                    }
                }
            }
        }
        public void imprimir()
        {
            Console.Write("la lista de vendedores de mayor a menor:");
           for (int i = 0;i < vendedor.Length; i++)
            {
                Console.WriteLine(vendedor[i]+" " + ventatotal[i]);
            }
            Console.WriteLine("el que vendio menos es:" + vendedor[4]+" con " + ventatotal[4]);
        }
        static void Main(string[] args)
        {
            /*Una empresa registra los nombres de sus 5 vendedores y el total de ventas
            realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
            vectores paralelos, ordenar los datos de mayor a menor según las ventas,
            imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
            el que menos vendió de los 5 empleados.*/
            venta vn = new venta();
            vn.cargar();
            vn.orden();
            vn.imprimir();
            Console.ReadKey();
        }
    }
}
