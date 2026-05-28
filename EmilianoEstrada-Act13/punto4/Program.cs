using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class alumno
    {
        private string nombrealumno;
        private int[] notas;
        public alumno(){
            string linea;
            notas = new int[4];
            Console.Write("ingrese el nombre del alumno: ");
            linea = Console.ReadLine();
            nombrealumno = linea;
            for (int i = 0; i < 4; i++) {
                Console.Write("ingrese la nota del alumno: ");
                linea = Console.ReadLine();
                notas[i]=int.Parse(linea);
            }    
        }
        public string nombre()
        {
            return nombrealumno;
        }
        public int promedio()
        {
            int suma=0,promedio=0;
            for (int i = 0; i < 4; i++) {
                suma = suma + notas[i];
            }
            promedio = suma / 4;
            return promedio;
        }
        public bool aprobado()
        {
            for (int i = 0; i < 4; i++) { 
            if(notas[i] < 6)
            {
                    return true;
            }
            }
            return false;
        }
    }
    class curso
    {
        private alumno[] alum;
        public curso() { 
            alum = new alumno[3];
            for (int i = 0; i < 3; i++) { 
            alum[i] = new alumno();
            }
        }
        public void imprimirpromedio()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("el alumno " + alum[i].nombre()+" tiene un promedio de "+ alum[i].promedio());
                Console.WriteLine();
            }
        }
        public void promediomayor()
        {
            string nombre = alum[0].nombre();
            int mayor = alum[0].promedio();
            for (int i = 1; i < 3; i++) {
                if (mayor < alum[i].promedio())
                {
                    mayor = alum[i].promedio();
                    nombre= alum[i].nombre();
                }
            }
            Console.Write("el alumno con mayor promedio es: " + nombre + " con un " + mayor);
            Console.WriteLine();
        }
        public void desaprobado()
        {
            for(int i = 0;i < 3; i++)
            {
                if (alum[i].aprobado())
                {
                    Console.Write("el alumno " + alum[i].nombre()+" tiene una nota desprobada");
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {/*Plantear una clase Alumno que tenga los atributos privados: nombre y un
        vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
        alumno y sus 4 calificaciones.
        Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
        Alumno.
        Agregar los siguientes métodos:
        a) Un método que imprima el nombre de cada alumno y su promedio.
        b) Un método que muestre el nombre del alumno con el promedio más
        alto.
        c) Un método que indique qué alumnos tienen al menos una nota
        desaprobada (nota menor a 6)*/
            curso curso = new curso();
            curso.imprimirpromedio();
            curso.promediomayor();
            curso.desaprobado();
            Console.ReadKey();
        }
    }
}
