using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Producto
    {
        private string nombre;
        private int precio,stock;
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
        public int Precio
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
        public Producto()
        {
            int numero = 0;
            Console.Write("ingrese el nombre del producto: ");
            Nombre = Console.ReadLine();
            for (int i = -1; i < 1; i--)
            {
                Console.Write("ingrese el precio del producto: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    Precio = numero;
                    i = 2;
                }
            }


            for (int i = -1; i < 1; i--)
            {
                Console.Write("ingrese cuanto producto tiene : ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    Stock = numero;
                    i = 2;
                }
            }
        }   
    }
    class Invetario
    {
        private Producto produ1, produ2, produ3;
        public Invetario(){
            produ1 = new Producto();
            produ2 = new Producto();
            produ3 = new Producto();
        }
        public void Menormayor()
        {
            if ((produ1.Precio >produ2.Precio)&& (produ1.Precio > produ3.Precio)) {
                Console.WriteLine("el producto mas caro es "+produ1.Nombre);
                if (produ2.Precio > produ3.Precio)
                {
                    Console.WriteLine("el orden de menor a mayor:");
                    Console.WriteLine(produ3.Nombre);
                    Console.WriteLine(produ2.Nombre);
                    Console.WriteLine(produ1.Nombre);
                }
                else
                {
                    Console.WriteLine("el orden de menor a mayor:");
                    Console.WriteLine(produ2.Nombre);
                    Console.WriteLine(produ3.Nombre);
                    Console.WriteLine(produ1.Nombre);
                }
            }
            if ((produ2.Precio > produ1.Precio) && (produ2.Precio > produ3.Precio))
            {
                Console.WriteLine("el producto mas caro es " + produ2.Nombre);
                if (produ1.Precio > produ3.Precio)
                {
                    Console.WriteLine("el orden de menor a mayor:");
                    Console.WriteLine(produ3.Nombre);
                    Console.WriteLine(produ1.Nombre);
                    Console.WriteLine(produ2.Nombre);
                }
                else
                {
                    Console.WriteLine("el orden de menor a mayor:");
                    Console.WriteLine(produ1.Nombre);
                    Console.WriteLine(produ3.Nombre);
                    Console.WriteLine(produ2.Nombre);
                }
            }
            else
            {
                Console.WriteLine("el producto mas caro es " + produ3.Nombre);
                if (produ2.Precio > produ1.Precio)
                {
                    Console.WriteLine("el orden de menor a mayor:");
                    Console.WriteLine(produ1.Nombre);
                    Console.WriteLine(produ2.Nombre);
                    Console.WriteLine(produ3.Nombre);
                }
                else
                {
                    Console.WriteLine("el orden de menor a mayor:");
                    Console.WriteLine(produ2.Nombre);
                    Console.WriteLine(produ1.Nombre);
                    Console.WriteLine(produ3.Nombre);
                }
            }
        }
        static void Main(string[] args)
        {/*Plantear una clase Producto y otra clase Inventario.
        La clase Producto debe tener como atributos privados el nombre, precio y
        stock. Definir propiedades para acceder a estos atributos, asegurando que el
        stock no pueda ser negativo y el precio sea mayor a cero.
        La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
        método para mostrar todos los productos ordenados de menor a mayor en
        base al precio, además, mostrar el producto más caro y más barato del
        inventario.*/
            Invetario i = new Invetario();
            i.Menormayor();
            Console.ReadKey();
        }
    }
}
