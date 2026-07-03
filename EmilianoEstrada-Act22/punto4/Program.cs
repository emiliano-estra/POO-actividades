using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    class Vuelo
    {
        public string codigo;
        public DateTime horasalida,horallegada;
        public Vuelo(string codigo,DateTime horasalida,DateTime horallegada){
            this.codigo = codigo;
            this.horasalida = horasalida;
            this.horallegada = horallegada;
        }
        public TimeSpan Duracion()
        {
            TimeSpan duracion = horallegada-horasalida;
            return duracion;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
         Usar la palabra clave this en el constructor para diferenciar los parámetros de
        los atributos.
         Crear un método para calcular la duración del vuelo (TimeSpan).
         Cargar un vector con 4 vuelos y mostrar:
        1. El código y duración del vuelo más largo.
        2. El código del vuelo que salga más temprano.*/
            Vuelo[] t;
            t = new Vuelo[4];
            string linea,codigo;
            int indicemax=0, indicemin=0;
            DateTime corto = new DateTime(2026,12, 31, 23,59,59);
            TimeSpan largo=new TimeSpan(0,0,0),duracion;
            DateTime horasalida,horallegada;
            for(int i = 0; i < t.Length; i++) {
            Console.WriteLine("ingrese el codigo de vuelo: ");
                codigo = Console.ReadLine();
                Console.WriteLine("ingrese la hora de salida(yyyy/MM/dd hh:mm): ");
                linea = Console.ReadLine();
                horasalida = DateTime.Parse(linea);
                Console.WriteLine("ingrese la hora de llegada(yyyy/MM/dd hh:mm): ");
                linea = Console.ReadLine();
                horallegada = DateTime.Parse(linea);
                t[i]=new Vuelo(codigo,horasalida,horallegada);
                duracion = t[i].Duracion();
                if(largo<duracion) {
                largo = duracion;
                    indicemax = i;
                }
                if (corto > t[i].horasalida) {
                corto=t[i].horasalida;
                    indicemin = i;
                }
            }
            Console.WriteLine("el codigo del vuelo mas largo es :" + t[indicemax].codigo+" la duracion del vuelo es de " + largo);
            Console.WriteLine("el codigo del vuelo que sale mas temprano :" + t[indicemin].codigo);
            Console.ReadKey();
        }
    }
}
