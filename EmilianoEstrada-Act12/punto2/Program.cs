using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class cine
    {
        string[] sala;
        int[][] cines;
        public void cargaSala()
        {
            sala = new string[4];
            cines = new int[4][];
            cines[0] = new int[10];
            cines[1] = new int[15];
            cines[2] = new int[8];
            cines[3] = new int[12];
            for (int i = 0; i < 4; i++)
            {
                sala[i] = "sala" + i;
                Console.WriteLine(sala[i]);
                for (int j = 1; j < cines[i].Length+1; j++)
                {
                    Console.Write(cines[i] [j-1]);
                    if (j == cines[i].Length+ / 2)
                    {
                        Console.Write("\n");
                    }
                    
                }
                Console.WriteLine();
            }

        }
        public void ventaDeEntradas()
        {
            string linea;
            int cantVoletos=0;
            int salaL = 0;
            int voletosSala = 0;
            int fila = 0;
            int columna = 0;
            int edad = 0;
            Console.Write("ingrese cuantos voletos quiere: ");
            linea=Console.ReadLine();
            cantVoletos=int.Parse(linea);
            for (int i = 0; i < cantVoletos; i++) {
                Console.Write("ingrese en que sala va a comprar su voleto: ");
                linea = Console.ReadLine();
                salaL=int.Parse(linea);
                Console.Write("cuantos voletos quiere para la sala" + sala[salaL] +": ");
                linea = Console.ReadLine();
                voletosSala = int.Parse(linea);
                for (int g = 0; g < voletosSala; g++) {
                    Console.Write("ingrese la fila: ");
                    linea = Console.ReadLine();
                    fila=int.Parse(linea);
                    Console.Write("ingrese la columna: ");
                    linea = Console.ReadLine();
                    columna = int.Parse(linea);
                    for (int j = 0; j < 1; j++) {
                        Console.Write("ingrese la edad de la persona: ");
                        linea = Console.ReadLine();
                        edad = int.Parse(linea);
                        if (fila == 2)
                        {
                            columna = columna + cines[salaL].Length/2;
                        }
                        cines[salaL][columna]=edad;
                    }
                }
                i=i+voletosSala-1;
            }

        }
        public void calcularPromedio(){
            int cantMenores = 0;
            int suma = 0;
            int cantPersonas = 0;
            double promedio = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < cines[i].Length; j++) {
                        if (cines[i][j] < 18&& cines[i][j]>0)
                        {
                            cantMenores++;
                        }
                        suma = suma + cines[i][j];
                        cantPersonas++;
                }
                Console.Write("en la sala " + i + " hay " + cantMenores + " menores de edad.");
               cantMenores = 0;
            }
            promedio = suma / cantPersonas;
            Console.Write("el promedio de edad es " + promedio);
        }
        static void Main(string[] args)
        {/*Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
        asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
        ● Definir una matriz irregular de 4 filas para representar los asientos.
        ● Métodos:
        1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
        intervención del operador).
        2. Crear un método de Venta de Entradas que permita cargar la edad del
        espectador en un asiento específico (fila y columna).
        3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
        en cada asiento.
        4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
        5. Informar cuál es el promedio de edad de los espectadores de todo el
        complejo.*/
            cine persona = new cine();
            persona.cargaSala();
            persona.ventaDeEntradas();
            persona.calcularPromedio();
            Console.ReadKey();
        }
    }
}
