using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class envios
    {
        private string[] sucursales;
        private int[][] paquetes;
        private int[] peso_sucursal;
        public void carga()
        {
            string linea;
            sucursales = new string[3];
            paquetes = new int[3][];
            for (int i = 0; i < 3; i++) {
                Console.Write("ingrese el nombre de la sucursal: ");
                sucursales[i] = Console.ReadLine();
                Console.Write("ingrese cuantos paquetes se despacharon en el dia: ");
                linea = Console.ReadLine();
                paquetes[i] = new int[int.Parse(linea)];
                for (int j = 0; j < paquetes[i].Length; j++) {
                    Console.Write("ingrese el peso del paquete en kg (1000g, sin poner gramos) de la sucursal " + sucursales[i]+": ");
                    linea= Console.ReadLine();
                    paquetes[i][j]=int.Parse(linea);
                }
            }

        }
        public void imprimir() {
            int peso_max = 0;
            string nombre_empresa="" ;
            peso_sucursal = new int[3];
        for(int i = 0; i < 3;i++) {
                Console.Write(sucursales[i]+": ");
                for (int j = 0; j < paquetes[i].Length; j++) {
                    Console.Write(paquetes[i][j] + " ");
                    peso_sucursal[i] = paquetes[i][j] + peso_sucursal[i];
                    if (peso_max < paquetes[i][j])
                    {
                        peso_max=paquetes[i][j];
                        nombre_empresa = sucursales[i];
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(sucursales[i]+" despacho en peso: " + peso_sucursal[i]);
                Console.WriteLine();
            }
            Console.Write("la sucurasl con el paquete ma pesado es: "+nombre_empresa+" con "+peso_max);
        }
        
        static void Main(string[] args)
        {/*Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
        cantidad diferente de paquetes por día dependiendo de su demanda.
        ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
        represente el peso (en kg) de cada paquete enviado.
        ● Métodos:
        1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
        paquetes se enviaron hoy para definir el tamaño de su fila.
        2. Cargar el peso de cada paquete.
        3. Imprimir el peso de todos los paquetes organizados por sucursal.
        4. Calcular e informar el peso total despachado por cada sucursal.
        5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
        pertenece.*/
            envios paquete =new envios();
            paquete.carga();
            paquete.imprimir();
            Console.ReadKey();
        }
    }
}
