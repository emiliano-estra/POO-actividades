using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Sondaexploradora
    {
        protected string modelo;
        protected int automiaminutus;
         public string Modelo
        {
            set
            {
                modelo = value;
            }
            get
            {
                return modelo;
            }
        }
        public int Automiaminutus
        {
            set
            {
                automiaminutus = value;
            }
            get
            {
                return automiaminutus;
            }
        }
        public Sondaexploradora(){
            string linea;
            Console.WriteLine("ingrese el modelo de la sonda: ");
            Modelo = Console.ReadLine();
            Console.WriteLine("ingrese la autonomia minutos de la sonda: ");
            linea = Console.ReadLine();
            Automiaminutus=int.Parse(linea);
        }
       
    }
    class Sondasubmarina : Sondaexploradora
    {
        protected int presionmaximaatm;
         public int Presionmaximaatm
        {
            set
            {
                presionmaximaatm = value;
            }
            get
            {
                return presionmaximaatm;
            }
        }
        public Sondasubmarina(){
            string linea;
            Console.WriteLine("ingese la presion maxima de la sonda submarina: ");
            linea= Console.ReadLine();
            Presionmaximaatm=int.Parse(linea);
        }
       
        public void imprimirs()
        {
            Console.WriteLine("modelo de la sonda sumamarina " + Modelo + " con una autonimina de " + Automiaminutus + " con un limite de " + Presionmaximaatm+" atmosferas");
        }
    }
    class Roverterrestre : Sondaexploradora
    {
        protected int cantidadruedas;
         public int Cantidadruedas
        {
            set
            {
                cantidadruedas = value;
            }
            get
            {
                return cantidadruedas;
            }
        }
        public Roverterrestre() {
            string linea;
            Console.WriteLine("ingrese cuantas cantidad de ruedas tiene el rover: ");
            linea = Console.ReadLine();
            Cantidadruedas=int.Parse(linea);
        } 
        public void imprimirr()
        {
            Console.WriteLine("modelo del rover "+Modelo+" con una autonimina de "+Automiaminutus+" teniendo una cantidad de ruedas "+Cantidadruedas);
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {/*Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
        AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
        realice su asignación.
        Luego, definir dos clases derivadas de la clase base:
        ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
        soportada en atmósferas).
        ● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
        Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
        tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
        clase SondaExploradora mediante el uso explícito de la palabra clave base.
        En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
        parámetros unificados por consola.*/
            Sondasubmarina sub = new Sondasubmarina();
            sub.imprimirs();
            Roverterrestre rover = new Roverterrestre();
            rover.imprimirr();
            Console.ReadKey();
        }
    }
}
