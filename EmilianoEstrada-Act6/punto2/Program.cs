using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Program
    {
        class Cuadrado
        {
            private int lado;
            public void ingresar_numero()
            {
                string linea;
                Console.Write("ingresar el lado del cuadrado:");
                linea = Console.ReadLine();
                lado = int.Parse(linea);
            }
            public void imprimir()
            {
                int perimetro;
                int superficie;
                    perimetro=Calcular_perimetro(lado);
                superficie = calcular_superficie(lado);
                   Console.WriteLine("el perimetro es:" + perimetro );
                Console.WriteLine("la superficie es:" + superficie );
            }

            public int Calcular_perimetro(int num)
            {
                num = lado * 4;
                return num;
            }
            public int calcular_superficie(int superficie)
            {
                superficie = lado * lado;
                return superficie;
            }

            static void Main(string[] args)
            {
                /*Desarrollar una clase que represente un Cuadrado y tenga los siguientes
                métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.*/
                Cuadrado cuadrado = new Cuadrado();
                cuadrado.ingresar_numero();
                cuadrado.imprimir();
                Console.ReadKey();
            }
        }
    }
}