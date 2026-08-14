using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    class Ticket
    {
        private string patente;
        private int horasestadia;
        public string Patente
        {
            get
            {
                return patente;
            }
        }
        public int Horasestadia
        {
            get
            {
                return horasestadia;
            }
        }
        public Ticket(string patente,int hora) { 
            this.patente=patente;
            horasestadia = hora;
        }
    }
    class Gestionestacionamiento
    {
        List<Ticket> t = new List<Ticket>();
        public void Registraringreso()
        {
            string linea, patente;
            int hora;
            Console.WriteLine("ingrese la patente: ");
            patente = Console.ReadLine();
            Console.WriteLine("ingrese la hora que se quedara: ");
            linea = Console.ReadLine();
            hora = int.Parse(linea);
            Ticket b = new Ticket(patente, hora);
            t.Add(b);
        }
        public void Procesarsalida()
        {
            if (t.Count > 0) {
                Console.WriteLine("la patente del coche que quiere salir es " + t[0].Patente+" con " + t[0].Horasestadia+" horas de estadia");
                t.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("no hay vehiculos que esperan salir");
            }
        }
        public void Mostrarvehiculosestacionados()
        {
            Console.WriteLine("lista de vehiculos: ");
            foreach (Ticket h in t)
            {
                Console.WriteLine(h.Patente+" hora de estadia "+h.Horasestadia);
            }
            Console.WriteLine("hay "+t.Count+" vehiculos en el estacionamiento");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Un estacionamiento medido administra el ingreso y la salida de los vehículos que
        utilizan su playa por orden de llegada.
         Crear la clase Ticket que contenga como atributos privados: patente
        (string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
        constructor que reciba pat y hs.
         Crear la clase GestionEstacionamiento que administre una lista
        dinámica de tickets (List).
         Métodos en GestionEstacionamiento:
        o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
        agregarlo al final de la lista utilizando .Add().
        o ProcesarSalida(): Si la lista no está vacía, simular la salida del
        primer vehículo de la lista (mostrar sus datos en consola) y
        removerlo de la colección mediante .RemoveAt(0). Si está vacía,
        advertir que no hay vehículos esperando salida.
        o MostrarVehiculosEstacionados(): Listar todos los vehículos
        alojados en la playa y la cantidad total de unidades presentes
        utilizando la propiedad .Count.*/
            Gestionestacionamiento j=new Gestionestacionamiento();
            j.Registraringreso();
            j.Registraringreso();
            j.Registraringreso();
            j.Procesarsalida();
            j.Mostrarvehiculosestacionados();
            Console.ReadKey();
        }
    }
}
