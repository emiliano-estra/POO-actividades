using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class notas
    {
        private string[] docente;
        private int[] nota;
        public void carga()
        {
            string linea;
            docente = new string[5];
            nota = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("ingrese el nombre del docente: ");
                linea = Console.ReadLine();
                docente[i]=linea;
                Console.Write("ingrese el nota del docente: ");
                linea= Console.ReadLine();
                nota[i]=int.Parse(linea);
            }
        }
        public void imprimir()
        {
            int baja = 0, alta = 0;
            alta = calcular_mayor();
            baja = calcular_menor();
            Console.WriteLine("el docente con mejor nota es: "+alta);
            Console.WriteLine("el docente con el peor nota es: "+baja);
            ordenar();
            Console.WriteLine("los docentes que aprobaron son: ");
            for (int i = 0; i < 5; i++) {
                if (nota[i] >= 6)
                {
                    Console.WriteLine(docente[i]);
                }
            }
        }
        public int calcular_mayor()
        {
            int mayor = 0;
            for (int i = 0; i < docente.Length; i++)
            {
                if (mayor < nota[i])
                {
                    mayor = nota[i];
                }
            }
            return mayor;
        }
        public int calcular_menor()
        {
            int menor = nota[0];
            for (int i = 1; i < docente.Length; i++)
            {
                if (menor > nota[i])
                {
                    menor = nota[i];
                }
            }
            return menor;
        }
        public void ordenar()
        {
            int aux=0;
            string aux_nom = "";
            for (int j = 0; j < docente.Length; j++)
            {
                for (int i = 0; i < docente.Length-j; i++)
                {
                    if (i != nota[i]-1)
                    {
                        if (nota[i] < nota[i + 1])
                        {
                            aux_nom = docente[i];
                            docente[i] = docente[i + 1];
                            docente[i + 1] = aux_nom;
                            aux = nota[i];
                            nota[i] = nota[i + 1];
                            nota[i + 1] = aux;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            /*Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
            sus nombres y puntajes promedio obtenidos (de 1 a 10).
            Cargar sus datos en vectores paralelos, mostrar docente con calificación más
            alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
            calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
            desaprobaron (tomando como base que se aprueba con una nota mayor o igual
            a 6)*/
            notas docente = new notas();
            docente.carga();
            docente.imprimir();
            Console.ReadKey();
        }
    }
}
