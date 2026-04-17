using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Notas_alum
    {
        private string[] alumno;
        private int[] nota;
        private int[] posicionMax;
        private int[] posicionMin;
        public void cargar()
        {
            alumno = new string[6];
            nota= new int[6];
            string linea;
            for(int i = 0; i < alumno.Length; i++)
            {
                Console.Write("ingrese el nombre del alumno: ");
                linea = Console.ReadLine();
                alumno[i] = linea;
                Console.Write("ingrese la nota del alumno: ");
                linea= Console.ReadLine();
                nota[i] =int.Parse(linea);
            }
        }
        public void cantMax_numMax()
        {
            int cant = 0, max = 0, u = 0;
            for (int i = 0; i < alumno.Length; i++)
            {
                if (max < nota[i])
                {
                    max = nota[i];
                    
                }
            }
            for (int f = 0; f < alumno.Length; f++)
            {
                if (max == nota[f])
                {
                    cant++;
                    
                }
            }
            posicionMax = new int[cant];
            for (int p = 0; p < nota.Length; p++)
            {
                if (max == nota[p])
                {
                    posicionMax[u] = p;
                    
                    u++;

                }
            }
        }
        public void cantMin_numMin()
        {
            int cant2 = 0, min = 10, u = 0;
            for (int i = 0; i < alumno.Length; i++)
            {
                if (min > nota[i])
                {
                    min = nota[i];
                }
            }
            for (int f = 0; f < alumno.Length; f++)
            {
                if (min == nota[f])
                {
                    cant2++;
                }
            }
            posicionMin = new int[cant2];
            for (int p = 0; p < nota.Length; p++)
            {
                if (min == nota[p])
                {
                    posicionMin[u] = p;
                    u++;
                }
            }
        }
        public void imprimir()
        {
            string alumnoMax="",alumnoMin="";
            for(int i = 0; i < posicionMax.Length; i++)
            {
                alumnoMax+= alumno[posicionMax[i]]+" ";
            }
            for (int i = 0; i < posicionMin.Length; i++)
            {
                alumnoMin += alumno[posicionMin[i]] + " ";
            }
            if (posicionMax.Length > 2 && posicionMin.Length>2)
            {
                Console.WriteLine("los alumnos " + alumnoMax + " son los que tiene la nota maxima con un " + nota[posicionMax[0]]);
                Console.WriteLine("los alumnos " + alumnoMin + " son los que tiene la nota minima con un " + nota[posicionMin[0]]);
            }
            else if(posicionMax.Length>2 && posicionMin.Length < 2)
            {
                Console.WriteLine("los alumnos " + alumnoMax + " son los que tiene la nota maxima con un " + nota[posicionMax[0]]);
                Console.WriteLine("el alumno " + alumnoMin + " es el que tiene la nota minima con un " + nota[posicionMin[0]]);
            }
            else if (posicionMax.Length < 2 && posicionMin.Length > 2)
            {
                Console.WriteLine("el alumno " + alumnoMax + " es el que tiene la nota maxima con un " + nota[posicionMax[0]]);
                Console.WriteLine("los alumnos " + alumnoMin + " son los que tiene la nota minima con un " + nota[posicionMin[0]]);
            }
            else
            {
                Console.WriteLine("el alumno " + alumnoMax + " es el que tiene la nota maxima con un " + nota[posicionMax[0]]);
                Console.WriteLine("el alumno " + alumnoMin + " es el que tiene la nota minima con un " + nota[posicionMin[0]]);
            }
        }
        static void Main(string[] args)
        {
            /*Se desea desarrollar un programa que permita registrar los nombres y las
            calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
            nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
            estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
            máxima o mínima.*/
            Notas_alum alumno=new Notas_alum();
            alumno.cargar();
            alumno.cantMax_numMax();
            alumno.cantMin_numMin();
            alumno.imprimir();
            Console.ReadKey();
        }
    }
}
