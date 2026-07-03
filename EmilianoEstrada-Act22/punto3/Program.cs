using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    class Entrenamiento
    {
        public string deportista;
        public int duracion;
        public int Registrarduracion(int hora,int minuto)
        {
             duracion = minuto + hora * 60;
            return duracion;
        }
        public int Registrarduracion(int minuto)
        {
             duracion = minuto;
            return duracion;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
         Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
        1. Uno que reciba horas y minutos y los convierta a minutos.
        2. Otro que reciba directamente los minutos.
         Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
        más corto.*/
            List<Entrenamiento>h=new List<Entrenamiento>();
            Entrenamiento[] e;
            e= new Entrenamiento[5];
            string linea;
            int horas=0,minutos,max=0,min=0,indice=0,indicemin=0,indicemax=0;
            for(int i=0;i<5;i++){
                e[i]=new Entrenamiento();
                Console.WriteLine("ingrese el nombre del deportista: ");
                e[i].deportista = Console.ReadLine();
                Console.WriteLine("duracion del entrenamiento horas: ");
                linea = Console.ReadLine();
                if(int.Parse(linea) > 0)
                {
                    horas=int.Parse(linea);
                }
                Console.WriteLine("ingrese la duracion de entrenamiento minutos: ");
                linea= Console.ReadLine();
                minutos=int.Parse(linea);
                if (horas > 0)
                {
                    e[i].Registrarduracion(horas, minutos);
                    if (i == 4)
                    {
                        min = e[i].duracion;
                    }
                }
                else
                {
                    e[i].Registrarduracion(minutos);
                }
                h.Add(e[i]);
            }
            foreach (Entrenamiento p in h)
            {
                if (max < p.duracion)
                {
                    max = p.duracion;
                    indicemax=indice;
                }
                if (min > p.duracion)
                {
                    min = p.duracion;
                    indicemin=indice;
                }
                indice++;
            }
            Console.WriteLine("el entrenamiento mas largo es: " + h[indicemax].deportista + " con " + h[indicemax].duracion);
            Console.WriteLine("el entrenamiento mas corto es: " + h[indicemin].deportista + " con " + h[indicemin].duracion);
            Console.ReadKey();
        }
    }
}
