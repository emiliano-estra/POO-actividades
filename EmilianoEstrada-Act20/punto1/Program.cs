using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Vuelo
    {
        protected int numerovuelo,duracionhoras;
        protected string destino;
        public int Numerovuelo
        {
            set
            {
                numerovuelo=value;
            }
            get
            {
                return numerovuelo;
            }
        }
        public string Destino
        {
            set
            {
                destino=value;
            }
            get
            {
                return destino;
            }
        }
        public int Duracionhoras
        {
            set
            {
                duracionhoras=value;
            }
            get
            {
                return duracionhoras;
            }
        }
        public Vuelo(){
            
        }
    }
    class Vuelointernacional : Vuelo 
    {
        protected string paisdestino;
        public string Paisdestino
        {
            set
            {
                paisdestino = value;
            }
            get
            {
                return paisdestino;
            }
        }
        public Vuelointernacional(int n,string d,int dh,string p)
        {
            Paisdestino = p;
            Numerovuelo = n;
            Destino = d;
            Duracionhoras = dh;
        }
        public void Lista()
        {
            List<Vuelointernacional> v = new List<Vuelointernacional>();
            for (int i = 0; i < 3; i++)
            {
                string linea;
                Console.WriteLine("ingrese el numero de vuelo: ");
                linea = Console.ReadLine();
                int numerovuelo = int.Parse(linea);
                Console.WriteLine("ingrese el destino del vuelo: ");
                string destino = Console.ReadLine();
                Console.WriteLine("ingrese la duracion en horas: ");
                linea = Console.ReadLine();
                int duracionhoras = int.Parse(linea);
                Console.WriteLine("ingrese el pais de destino: ");
                string paisdestino = Console.ReadLine();
                Vuelointernacional t = new Vuelointernacional(numerovuelo,destino,duracionhoras,paisdestino);
                v.Add(t);
            }
            foreach (Vuelointernacional u in v)
            {
                Console.WriteLine("numero de vuelo:"+u.Numerovuelo+" destino:"+u.Destino+" duracion horas:"+u.Duracionhoras+" pais destino:"+u.Paisdestino);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {/*Una aerolínea administra los vuelos programados mediante un sistema orientado a
        objetos.
        Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
        destino y duración en horas. Luego definir una clase derivada VueloInternacional que
        herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
        Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
        desde consola y luego:
         Mostrar los vuelos registrados y el país de destino.
         Informar cuál es el vuelo con mayor duración.
         Mostrar el orden de ejecución de los constructores.*/
            Vuelointernacional y=new Vuelointernacional(1,"h",2,"u");
            y.Lista();
            Console.ReadKey();
        }
    }
}
