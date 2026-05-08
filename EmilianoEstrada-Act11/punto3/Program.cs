using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace punto3
{
    internal class falta
    {
        private string[] empleados;
        private string[][] dias_faltados;
        public void carga()
        {
            empleados = new string[3];
            dias_faltados = new string[3][];
            int cant = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("ingresar el nombre del empleado: ");
                empleados[i]=Console.ReadLine();
                Console.Write("ingrese cuantos dias falto el empleado " + empleados[i]+" :");
                cant=int.Parse(Console.ReadLine());
                dias_faltados[i]=new string[cant];
                for (int j = 0; j < cant; j++) { 
                Console.Write("ingrese que dia falto el empleado " + empleados[i]+"(ingresando dia/mes) :");
                    dias_faltados[i][j] = Console.ReadLine();
                }
            }
        }
        public void imprimir()
        {
            int diasfalta = dias_faltados[0].Length,posicion=0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write(empleados[i] + " falto: ");
                for (int j = 0; j < dias_faltados[i].Length; j++)
                {
                    Console.Write(" " + dias_faltados[i][j] + " ");
                }
                if (diasfalta > dias_faltados[i].Length)
                {
                    diasfalta = dias_faltados[i].Length ;
                    posicion = i;
                }
                Console.Write("\n");
            }
            Console.Write("el empleado que menos falto fue " + empleados[posicion]+" con "+diasfalta+" dias faltado");
        }
        static void Main(string[] args)
        {/*Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
        empresa.
        Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
        irregular para cargar los días que han faltado cada empleado (cargar el número de día que
        faltó)
        Cada fila de la matriz representa los días de cada empleado.
        a. Mostrar los empleados con la cantidad de inasistencias.
        b. Cuál empleado faltó menos días.*/
            falta empleado=new falta();
            empleado.carga();
            empleado.imprimir();
            Console.ReadKey();
        }
    }
}
