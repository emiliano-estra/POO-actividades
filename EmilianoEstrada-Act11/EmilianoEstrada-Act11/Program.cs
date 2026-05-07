using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class temperatura
    {
        private string[] paises;
        private double[,] temperaturas;
        private double[] trimestre;
        public void carga()
        {
            temperaturas = new double[4, 3];
            paises = new string[4];
            string linea;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese el nombre del pais: ");
                linea = Console.ReadLine();
                paises[i] = linea;
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("ingrese la temperatura del pais en el mes "+j+": " );
                    linea= Console.ReadLine();
                    temperaturas[i,j]=double.Parse(linea);
                }
            }
        }
        public void calcular_temperatura_tri()
        {
            double suma = 0;
            trimestre = new double[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma = suma + temperaturas[i, j];
                }
                trimestre[i] = suma/3;
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(paises[i]+":");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" "+temperaturas[i, j]+" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("temperaturas trimestrales:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(paises[i]+":");
                    Console.Write(" "+trimestre[i]+" ");
                Console.Write("\n");
            }
        }
        public void mayor_temperatura()
        {
            double mayor=trimestre[0];
            string nombre_pais="";
            for (int i = 0; i < 4; i++)
            {

                if (mayor < trimestre[i])
                {
                    mayor = trimestre[i];
                    nombre_pais = paises[i];
                }
            }
            Console.WriteLine("el pais que tiene temperaturas trimestrales mayor : "+nombre_pais+" con "+mayor);
        }
        static void Main(string[] args)
        {
            /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
            dato las temperaturas medias mensuales de dichos paises.
            Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
            mensuales.
            Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
            memoria.
            a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
            b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
            mismas.
            c. Calcular la temperatura media trimestral de cada país.
            d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
            e. Imprimir el nombre del país con la temperatura media trimestral mayor.*/
            temperatura matriz = new temperatura();
            matriz.carga();
            matriz.calcular_temperatura_tri();
            matriz.imprimir();
            matriz.mayor_temperatura();
            Console.ReadKey();
        }
    }
}
