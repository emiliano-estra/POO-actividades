using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace punto3
{
    internal class chef
    {
        string[] alumno;
        int[][] plato;
        public void cargar()
        {
            alumno = new string[3];
            plato = new int[3][];
            plato[0] = new int[2];
            plato[1] = new int[4];
            plato[2] = new int[3];
            string linea;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("ingrese el nombre del alumno: ");
                linea = Console.ReadLine();
                alumno[i] = linea;

                for (int j = 0; j < plato[i].Length; j++)
                {
                    Console.Write("ingrese la calificacion del alumno en el plato " + j + " (ingrese de 0 a 100): ");
                    linea = Console.ReadLine();
                    if (int.Parse(linea) > 0 && int.Parse(linea) < 100)
                    {
                        plato[i][j] = int.Parse(linea);
                    }
                    else
                    {
                        Console.Write("ingreso mal el numero");
                        j--;
                    }
                }
            }
        }
        public void promedio()
        {
            double sumaPlato = 0;
            double promedio = 0;
            double mayorPromedio = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < plato[i].Length; j++)
                {
                    sumaPlato = sumaPlato + plato[i][j];
                }
                promedio = sumaPlato / plato[i].Length;
                sumaPlato = 0;
                if (mayorPromedio < promedio)
                {
                    mayorPromedio = promedio;
                }
                Console.Write("el alumno " + alumno[i] + "esta ");
                if (promedio >= 70)
                {
                    Console.Write("aprobado");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("desaprobado");
                    Console.WriteLine();
                }
                if (i == 2)
                {
                    Console.Write("el promedio mas alto es:"+mayorPromedio);
                }
            }

        }
        static void Main(string[] args)
        {/*Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
        una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
        ● Definir un vector para los nombres de los alumnos.
        ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
        presentado.
        ● Métodos:
        1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
        de cada alumno.
        2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
        3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
        4. Calcular el puntaje promedio de cada alumno e informar si está Aprobado
        (promedio >= 70) o Reprobado.
        5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
        valor máximo de la matriz).*/
            chef puntos=new chef();
            puntos.cargar();
            puntos.promedio();
            Console.ReadKey();
        }
    }
}
