using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto5
{
    class Vehiculo
    {
        private string patente;
        private double costoreparacion;
        public string Patente
        {
            set
            {
                patente = value;
            }
            get
            {
                return patente;
            }
        }
        public double Costoreparacion
        {
            set
            {
                costoreparacion = value;
            }
            get
            {
                return costoreparacion;
            }
        }
        public Vehiculo(string patente,double costo) { 
            Patente = patente;
            Costoreparacion = costo;
        }
    }
    class Gestiontaller
    {
        List<Vehiculo>v=new List<Vehiculo>();
        public string patente;
        public void Ingresarvehiculo()
        {
            for (int i = 0; i < 3; i++)
            {
                string patente, linea;
                double costo;
                Console.WriteLine("ingrese la patente: ");
                patente = Console.ReadLine();
                Console.WriteLine("ingreses el consto de reparaacion: ");
                linea = Console.ReadLine();
                costo = int.Parse(linea);
                Vehiculo au = new Vehiculo(patente, costo);
                v.Add(au);
            }
        }
        public void Buscarvehiculo()
        {
            
            Console.WriteLine("ingrese la patente del vehiculo que quiere buscar: ");
            patente=Console.ReadLine();
            foreach (Vehiculo t in v)
            {
                if (t.Patente.Equals(patente))
                {
                    Console.WriteLine("el vehiculo esta en el taller y tiene un caote de reparacion de "+t.Costoreparacion);
                }
            }
        }
        public void Entregarvehiculo()
        {
            Vehiculo tu=new Vehiculo("yu", 20);
            Console.WriteLine("ingrese la patente del vehiculo que buaca: ");
            patente= Console.ReadLine();
            foreach(Vehiculo t in v)
            {
                if (t.Patente.Equals(patente))
                {
                    tu = t;
                }
            }
            v.Remove(tu);
            Console.WriteLine("el vehiculo es entregado\n");
        }
        public void Calcularrecaudacionpendiente()
        {
            double total=0;
            foreach(Vehiculo t in v)
            {
                Console.WriteLine("el vehiculo con la patente "+t.Patente+" esta en el taller");
                total=t.Costoreparacion+total;
            }
            Console.WriteLine("hay "+v.Count+" vehiculo en el taller");
            Console.WriteLine("el coste de reparacion de todos los vehiculos es de "+total);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Un taller mecánico automatizado administra la recepción y egreso de automóviles
        que se encuentran en el sector de reparaciones.
         Crear la clase Vehiculo que contenga como atributos privados: patente
        (string) y costoReparacion (double). Definir sus propiedades
        correspondientes y un constructor que reciba pat y costo.
         Crear la clase GestionTaller que administre una lista de objetos List.
         Métodos en GestionTaller:
        o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
        reparación de un vehículo para agregarlo a la lista mediante .Add().
        o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
        recorriendo la lista, informar si el vehículo está en el taller y mostrar
        su costo asociado.
        o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
        vehículo en la lista y, si existe, removerlo de la colección mediante
        .Remove() confirmando la entrega del automóvil.
        o CalcularRecaudacionPendiente(): Listar los vehículos
        actualmente en reparación, la cantidad total de unidades alojadas en
        el taller mediante la propiedad .Count y la suma total acumulada por
        cobrar.*/
            Gestiontaller g=new Gestiontaller();
            g.Ingresarvehiculo();
            g.Buscarvehiculo();
            g.Entregarvehiculo();
            g.Calcularrecaudacionpendiente();
            Console.ReadKey();
        }
    }
}
