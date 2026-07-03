using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto5
{
    internal class Program
    {
        
        class Corredor
        {
            public string nombre;
            public int numerodorsal;
            public TimeSpan timepototal;
            public Corredor(string nombre, int numerodorsal, int hora, int minutos)
            {

            }
        }
        class Carrera
        {
            public string codigo,nombre;
            public int numerodorsal,hora,minutos;
            public DateTime horainicio, horafin;
            public List<Corredor> cor = new List<Corredor>();
            public Corredor[] par;
            public Carrera(){
                string linea;
                par=new Corredor[6];
                Console.WriteLine("ingrese el codigo de la carrera: ");
                codigo = Console.ReadLine();
                Console.WriteLine("ingrese la hora de inicio de la carrera(yyyy/MM/dd hh:mm): ");
                horainicio=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la hora de fin de la carrera(yyyy/MM/dd hh:mm): ");
                horafin = DateTime.Parse(Console.ReadLine());
                for(int i = 0; i < 6; i++)
                {
                    Console.WriteLine("ingrese el nombre del corredor: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingrese el numero del dorsal del corredor");
                    linea = Console.ReadLine();
                    numerodorsal = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese cuantas horas tiene de tiempo: ");
                    linea = Console.ReadLine();
                    hora = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese cuantos minutos tiene de tiempo: ");
                    linea = Console.ReadLine();
                    minutos = int.Parse(Console.ReadLine());
                    par[i] = new Corredor(nombre,numerodorsal,hora,minutos);
                }
            }
            public Carrera(Corredor)
            {
                cor.Add();
            }
            public void Duracion()
            {
                TimeSpan duracion = horafin - horainicio;
            }
        }
        static void Main(string[] args)
        {/*Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
        una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
        Se pide:
        1. Crear una clase Carrera con:
        o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
        definidos.
        o Dos constructores (uno por defecto y otro con parámetros).
        o Método para calcular la duración de la carrera usando TimeSpan.
        2. Crear una clase Corredor con:
        o Atributos: nombre, número de dorsal y tiempo total.
        o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
        horas y minutos).

        3. Mostrar en consola (usando Console.SetCursorPosition()):
        o La carrera con mayor duración.
        o El corredor más rápido.
        4. Utilizar this en los constructores o métodos donde corresponda.
            5. Deben ser 4 carreras.*/
            Console.ReadKey();

        }
    }
}
