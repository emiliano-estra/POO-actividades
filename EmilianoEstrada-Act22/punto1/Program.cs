using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    class ClaseGimnasio
    {
        public string nombreclase;
        public DateTime horainicio=new DateTime(),horafin=new DateTime();
        public ClaseGimnasio() {
            string linea;
            Console.WriteLine("ingrese el nombre de la clase: ");
            nombreclase = Console.ReadLine();
            Console.WriteLine("ingrese el año mes dia hora minuto que empiese la clase: ");
            linea = Console.ReadLine();
            horainicio = DateTime.Parse(linea);
            Console.WriteLine("ingrese el año mes dia hora minuto que termine la clase: ");
            linea = Console.ReadLine();
            horafin = DateTime.Parse(linea);
        }
        public ClaseGimnasio(string nombreclase,string horainicio,string horafin)
        {
            this.nombreclase=nombreclase;
            this.horainicio=DateTime.Parse(horainicio);
            this.horafin= DateTime.Parse(horafin);
        }
        public TimeSpan Timpoclase()
        {
            TimeSpan tipoclase = horainicio - horafin;
            Console.WriteLine(" la calse dura "+tipoclase.Hours+":"+tipoclase.Minutes);
            return tipoclase;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
        DateTime).
         Implementar un constructor que permita cargar los datos desde consola y otro
        que cargue valores por defecto (sobrecarga de constructores).
         Incluir un método para calcular la duración de la clase usando TimeSpan.
         Crear un vector de 3 clases de gimnasio y mostrar:
        1. La clase que tenga la mayor duración.
        2. El nombre y el horario de inicio de la clase más temprana.*/
            ClaseGimnasio[] t;
            TimeSpan mayor;
            for(int i=0; i<3; i++)
            {
                t = new ClaseGimnasio[3];
                t[i] = new ClaseGimnasio("rumba", "2026/07/08 08:05", "2026/07/08 10:05");
                t[i]= new ClaseGimnasio();
                
                if (mayor< t[i].Timpoclase())
                {

                }
            }
           
        }
    }
}
