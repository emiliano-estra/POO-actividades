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
            public TimeSpan tiempototal;
            public Corredor(string nombre, int numerodorsal)
            {
                this.nombre = nombre;
                this.numerodorsal = numerodorsal;
            }
            public void RegistrarTiempo(int minutos)
            {
                tiempototal = new TimeSpan(0, minutos, 0);
            }

            public void RegistrarTiempo(int horas, int minutos)
            {
                tiempototal = new TimeSpan(horas, minutos, 0);
            }
        }
        class Carrera
        {
            public string codigo,nombre;
            public int numerodorsal,hora,minutos;
            public DateTime horainicio, horafin;
            public List<Corredor> cor = new List<Corredor>();
            public Corredor c;
            public Carrera(){
                string linea;
                Console.WriteLine("ingrese el codigo de la carrera: ");
                codigo = Console.ReadLine();
                Console.WriteLine("ingrese la hora de inicio de la carrera(yyyy/MM/dd hh:mm): ");
                horainicio=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la hora de fin de la carrera(yyyy/MM/dd hh:mm): ");
                horafin = DateTime.Parse(Console.ReadLine());
                for(int i = 0; i < 2; i++)
                {
                    Console.WriteLine("ingrese el nombre del corredor: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingrese el numero del dorsal del corredor");
                    linea = Console.ReadLine();
                    numerodorsal = int.Parse(linea);
                    Console.WriteLine("ingrese cuantas horas tiene de tiempo: ");
                    linea = Console.ReadLine();
                    hora = int.Parse(linea);
                    Console.WriteLine("ingrese cuantos minutos tiene de tiempo: ");
                    linea = Console.ReadLine();
                    minutos = int.Parse(linea);
                    c = new Corredor(nombre, numerodorsal);
                    if(hora == 0)
                    {
                        c.RegistrarTiempo(minutos);
                    }
                    else
                    {
                        c.RegistrarTiempo(hora, minutos);
                    }
                        
                    cor.Add(c);
                }
            }
            public Carrera(Corredor ter)
            {
                cor.Add(ter);
            }
            public TimeSpan Duracion()
            {
                TimeSpan duracion = horafin - horainicio;
                return duracion;
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
            Carrera[] carreras = new Carrera[2];
            TimeSpan mayor;
            Corredor rapido;
            int indice = 0;
            for (int i = 0; i < 2; i++)
            {
                carreras[i] = new Carrera();
            }
            mayor = carreras[0].Duracion();
            rapido = carreras[0].cor[0];
            for (int i = 0; i < 2; i++) { 
                foreach (Corredor c in carreras[i].cor)
                {
                    if (rapido.tiempototal > c.tiempototal)
                    {
                        rapido = c;
                    }
                }
                if (mayor < carreras[i].Duracion())
                {
                    mayor = carreras[i].Duracion();
                    indice = i;
                }   
            }
            Console.Clear();

            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Carrera con mayor duración");

            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Código: " + carreras[indice].codigo);

            Console.SetCursorPosition(5, 4);
            Console.WriteLine("Duración: " + mayor);

            Console.SetCursorPosition(5, 7);
            Console.WriteLine("Corredor más rápido");

            Console.SetCursorPosition(5, 8);
            Console.WriteLine("Nombre: " + rapido.nombre);

            Console.SetCursorPosition(5, 9);
            Console.WriteLine("Dorsal: " + rapido.numerodorsal);

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("Tiempo: " + rapido.tiempototal);
            Console.ReadKey();

        }
    }
}
