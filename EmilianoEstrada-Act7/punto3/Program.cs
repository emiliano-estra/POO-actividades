using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Puntuacion
    {
        private int[] puntos;
        public void carga()
        {
            puntos = new int[6];
            string linea;
            for (int i = 1; i < 7; i++)
            {
                Console.Write("ingrese la puntuacion de la partida numero "+i+": ");
                linea = Console.ReadLine();
                puntos[i-1] = int.Parse(linea);
            }
        }
        public void imprimir()
        {
            int max,min,mas_500,promedio;
            max=maxima_puntuacion();
            min=minima_puntuacion();
            mas_500 = mayor_500();
            promedio = calcular_promedio();
            Console.WriteLine("la puntuacion maxima es: "+max);
            Console.WriteLine("la puntuacion minima es: " + min);
            Console.WriteLine("la cantidad de puntuacion mayor a 500 es: " + mas_500);
            Console.WriteLine("el promedio es: " + promedio);
        }
        public int maxima_puntuacion()
        {
            int maximo;
            maximo = puntos[0];
            for (int i = 1; i < 6; i++)
            {
                if (maximo < puntos[i])
                {
                    maximo = puntos[i];
                }
            }
            return maximo;
        }
        public int minima_puntuacion()
        {
            int minimo;
            minimo = puntos[0];
            for (int i = 1; i < 6; i++)
            {
                if (minimo > puntos[i])
                {
                    minimo = puntos[i];
                }
            }
            return minimo;
        }
        public int mayor_500()
        {
            int mayor;
            mayor = 0;
            for (int i = 0; i < 6; i++)
            {
                if (puntos[i]>500)
                {
                    mayor++;
                }
            }
            return mayor;
        }
        public int calcular_promedio()
        {
            int promedio,suma;
            promedio = 0;
            suma = 0;
            for (int i = 0; i < 6; i++)
            {
                suma = suma + puntos[i];
                if (i == 5) {
                    promedio = suma / 6;
                }
            }
            return promedio;
        }
        static void Main(string[] args)
        {
            /*Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
            un videojuego. El programa debe:
             Mostrar la puntuación más alta y la más baja.
             Calcular el promedio de puntuación.
             Contar cuántas veces superó los 500 puntos.*/
            Puntuacion punto = new Puntuacion();
            punto.carga();
            punto.imprimir();
            Console.ReadKey();
        }
    }
}
