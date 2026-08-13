using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    class Plato
    {
        private string nombreplato;
        private double precio;
        public string Nombreplato
        {
            set
            {
                nombreplato = value;
            }
            get
            {
                return nombreplato;
            }
        }
        public double Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }
        public Plato(string nom,double pre) {
            Nombreplato=nom;
            Precio = pre;
        }
    }
    class Gestioncomandas
    {
        List<Plato> g = new List<Plato>();
        public void Agregarplato()
        {
            string linea, nombre;
            double precio;
            Console.WriteLine("ingrese el nombre del plato: ");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese el precio del plato: ");
            linea = Console.ReadLine();
            precio=double.Parse(linea);
            Plato p=new Plato(nombre, precio);
            g.Add(p);
        }
        public void Mostrarcomanda()
        {
            foreach (Plato i in g)
            {
                Console.WriteLine("los platos que hay agregados a la comanda "+i.Nombreplato);
                
            }
            Console.WriteLine("platos total " + g.Count);
        }
        public void Cancelarplato()
        {
            string nombre;
            Console.WriteLine("ingrese el plato que quiere cancelar del pedido: ");
            nombre = Console.ReadLine();
            Plato t = g.FirstOrDefault(l => l.Nombreplato == nombre);
            g.Remove(t);
        }
        public void Calculartotalmesa()
        {
            double total=0;
            foreach (Plato t in g)
            {
                total=t.Precio + total;
            }
            Console.WriteLine("el costo de la mesa es de "+total);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Un restaurante automatizado procesa la comanda de una mesa para controlar la
        preparación y el cobro de los platos pedidos.
         Crear la clase Plato que contenga como atributos privados: nombrePlato
        (string) y precio (double). Definir sus propiedades correspondientes y un
        constructor que reciba nom y pre.
         Crear la clase GestionComandas que administre una lista de objetos List.
         Métodos en GestionComandas:
        o AgregarPlato():Solicitar por teclado los datos de un plato y
        agregarlo a la lista utilizando .Add().
        o MostrarComanda(): Listar todos los platos agregados hasta el
        momento junto a la cantidad total de ítems pedidos utilizando la
        propiedad .Count.
        o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
        total a cobrar sumando los precios de la lista.
        o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
        se encuentra en la lista, removerlo mediante .Remove() para
        actualizar la comanda.*/
            Gestioncomandas h=new Gestioncomandas();
            for(int i=0; i<3; i++)
            {
                h.Agregarplato();
            }
            h.Mostrarcomanda();
            h.Cancelarplato();
            h.Mostrarcomanda();
            h.Calculartotalmesa();
            Console.ReadKey();
        }
    }
}
