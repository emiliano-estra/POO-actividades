using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Vehiculo
    {
        protected string marca;
        protected int velocidadmax;
        public Vehiculo()
        {
            
        }
        public string Marca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }
        public int Velocidadmax
        {
            set
            {
                velocidadmax = value;
            }
            get
            {
                return velocidadmax;
            }
        }

    }
    class Auto : Vehiculo
    {
        private int cantidadpuertas;
        private Vehiculo base1;
        public Auto()
        {
            base1 = new Vehiculo();
            Console.WriteLine("ingrese la marca del auto:");
            base1.Marca = Console.ReadLine();
            Console.WriteLine("ingrese la velocidad maxima del auto: ");
            base1.Velocidadmax = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de puertas:");
            Cantidadpuertas = int.Parse(Console.ReadLine());
        }
        public int Cantidadpuertas
        {
            set
            {
                cantidadpuertas = value;
            }
            get
            {
                return cantidadpuertas;
            }

        }
        public void Imprimir()
        {
            Console.WriteLine("las caracterioticas del auto: " + base1.Marca + ", velocidad " + base1.Velocidadmax + " y cantidad de puertas " + Cantidadpuertas);
        }
    }
        class Moto : Vehiculo
        {
            private int cilindrada;
            private Vehiculo base2;
            public Moto() { 
            base2 = new Vehiculo();
                Console.WriteLine("ingrese la marca de la moto:");
                base2.Marca = Console.ReadLine();
                Console.WriteLine("ingrese la velocidad maxima de la moto: ");
                base2.Velocidadmax = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad de cilindradas: ");
                Cilindrada=int.Parse(Console.ReadLine());
            }
            public int Cilindrada
            {
                set
                {
                    cilindrada = value;
                }
                get
                {
                    return cilindrada;
                }
            }
            public void Imprimir()
            {
                Console.WriteLine("las caracterioticas de la moto: "+base2.Marca+", velocidad"+base2.Velocidadmax+" y cilindrada "+Cilindrada);
            }
        }
        class Pruebe
        {
            static void Main(string[] args)
            {/*Crear una clase base Vehículo que contenga atributos marca y
            velocidadMaxima.
            Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
            una debe tener un constructor que reciba los valores de los atributos base
            mediante la palabra clave base, y un atributo propio (cantidadPuertas en
            Auto, cilindrada en Moto).
            Crear un objeto de cada clase y mostrar todos sus datos por consola.*/
            Auto auto = new Auto();
            auto.Imprimir();
            Moto moto = new Moto();
            moto.Imprimir(); 
            }
        }
    }

