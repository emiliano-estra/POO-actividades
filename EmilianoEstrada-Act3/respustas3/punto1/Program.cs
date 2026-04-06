using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.*/
            DateTime fecha, navidad;
            int año;
            string linea;
            Console.Write("ingrese una fecha:");
            linea = Console.ReadLine();
            fecha = DateTime.Parse(linea);
            año= fecha.Year;
            navidad = new DateTime(año, 12, 25);


            if (fecha == navidad) {
                Console.Write("es navidad");
            }
            else
            {
                Console.WriteLine("no es navidad");
            }
            Console.ReadKey();
        }
    }
}
