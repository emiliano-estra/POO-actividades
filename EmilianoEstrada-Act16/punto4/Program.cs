using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Animal
    {
        protected string especie;
        public Animal()
        {
            Especie = "labrador";
            Console.WriteLine(" esta es la clase animales con la especie: "+especie);
        }
        public string Especie
        {
            set
            {
                especie=value;
            }
            get 
            { 
                return especie;
            }
        }
    }
    class Mamifero : Animal 
    {
        protected string tipoalimentacion;
        public Mamifero()
        {
            Tipoalimentacion = "carnivoros";
            Console.WriteLine("esta es la clase tipoalimentacion con una alimentacion: " + tipoalimentacion);
        }
        public string Tipoalimentacion
        {
            set
            {
                tipoalimentacion = value;
            }
            get
            {
                return tipoalimentacion;
            }
        }
    }
    class Perro : Mamifero
    {
        protected string nombre;
        public Perro()
        {
            Nombre = "chompi";
            Console.WriteLine("esta es la clase perro con el nombre del perro: " + nombre);
        }
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
    }
    class Prueba
    {
        static void Main(string[] args)
        {/*Armar tres clases: Animal, Mamífero y Perro.
        La clase Animal debe tener un atributo especie.
        La clase Mamífero, que hereda de Animal, debe tener un atributo
        tipoAlimentacion.
        La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
        Cada clase debe tener un constructor que reciba los datos correspondientes
        y los imprima indicando a qué clase pertenecen. Los datos deben ser
        asignados previamente
        Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
        constructores.*/
                Perro perro = new Perro();
                Console.ReadKey();
        }
    }
}
