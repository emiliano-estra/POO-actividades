using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Se cuenta con la siguiente información:
             ● Las edades de 20 estudiantes del turno mañana.
             ● Las edades de 30 estudiantes del turno tarde.
             ● Las edades de 15 estudiantes del turno noche.
             Las edades de cada estudiante deben ingresarse por teclado.
             a) Obtener el promedio de las edades de cada turno(tres promedios)
             b) Imprimir dichos promedios(promedio de cada turno)
             c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
             promedio de edades menor.*/
         
            double num, sum,promedio,promediomenor;
            string linea,promediototal,turno;
            num = 0;
            sum = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("ingrese la edad de los estudiantes del turno mañana:");
                linea = Console.ReadLine();
                num = double.Parse(linea);
                sum = sum + num;
                
            }
            promedio = sum / 20;
            promediomenor = promedio;
            turno = "el turno noche es el menor";
            promediototal ="el promedio del turno mañana es:"+promedio+"\n";
            sum = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("ingrese la edad de los estudiantes del turno tarde:");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                sum = sum + num;

            }
            promedio = sum / 30;
            if (promediomenor > promedio)
            {
                promediomenor=promedio;
                turno = "el turno tarde es el menor";
            }
            promediototal = promediototal+"el promedio del turno tarde es:" + promedio + "\n";
            sum = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("ingrese la edad de los estudiantes del turno noche:");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                sum = sum + num;

            }
            promedio= sum / 15;
            promediototal = promediototal + "el promedio del turno noche es:" + promedio + "\n";
            if (promediomenor > promedio)
            {
                promediomenor = promedio;
                turno = "el turno noche es el menor";
            }
            Console.WriteLine(promediototal);
            Console.WriteLine(turno);
            Console.ReadKey();

        }
    }
}
