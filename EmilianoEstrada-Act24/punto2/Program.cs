using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class Medicamento
    {
        private string nombre;
        private int stock;
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Stock
        {
            set
            {
                stock = value;
            }
            get
            {
                return stock;
            }
        }
        public Medicamento(string nombre,int stock) { 
            Nombre = nombre;
            Stock = stock;
        }
    }
    class Controlframacia
    {
        List<Medicamento>m=new List<Medicamento>();
        public Controlframacia() {
            string linea, nombre;
            int stock;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese el nombre del medicamento: ");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese el stock que hay del medicamento: ");
                linea = Console.ReadLine();
                stock = int.Parse(linea);
                Medicamento n = new Medicamento(nombre, stock);
                m.Add(n);
            }
        }
        public void Listarstock()
        {
            foreach(Medicamento t in m)
            {
                Console.WriteLine("el nombre del medicamento "+t.Nombre);
                Console.WriteLine("cantidad de medicamento disponible "+t.Stock+"\n");
            }
        }
        public void Removeragotados()
        {
            for (int i = m.Count-1; i >0 ; i--)
            {
                if (m[i].Stock == 0)
                {
                    m.RemoveAt(i);
                }
            }
        }
        public void Mostrarmedicamentosdisponibles()
        {
            foreach (Medicamento t in m)
            {
                Console.WriteLine("el nombre del medicamento " + t.Nombre);
                Console.WriteLine("cantidad de medicamento disponible " + t.Stock);
            }
            Console.WriteLine("la cantidad de medicamnetos disponibles es de "+m.Count);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Una farmacia controla el nivel de stock de sus medicamentos para evitar el
            desabastecimiento de insumos esenciales.
             Crear la clase Medicamento que contenga los atributos privados: nombre
            (string) y stock (int). Definir sus propiedades correspondientes. Su
            constructor debe recibir nom y stk.
             Crear la clase ControlFarmacia que administre una lista de objetos List.
             Métodos en ControlFarmacia:
            o Un constructor que cargue por teclado una lista inicial de 4
            medicamentos ingresando sus nombres y stock.
            o ListarStock(): Mostrar la lista de medicamentos en pantalla.
            o RemoverAgotados(): Recorrer la lista y remover por completo de
            la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
            o MostrarMedicamentosDisponibles(): Imprimir la lista
            actualizada y la cantidad de productos disponibles en el inventario
            utilizando la propiedad .Count.*/
            Controlframacia c= new Controlframacia();
            c.Listarstock();
            c.Removeragotados();
            c.Mostrarmedicamentosdisponibles();
            Console.ReadKey();
        }
    }
}