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
        public string Especie
        {
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }
        public Animal(string especienu,string tipoalimentacionnu,string nombrenu) 
        {
            Especie = especienu;
            Console.WriteLine(" esta es la clase animales con la especie: "+Especie);
        }
       
    }
    class Mamifero : Animal 
    {
        protected string tipoalimentacion;
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
        public Mamifero(string especienu,string tipoalimentacionnu,string nombrenu) : base(especienu,tipoalimentacionnu,nombrenu)
        {
            Tipoalimentacion = tipoalimentacionnu;
            Console.WriteLine("esta es la clase tipoalimentacion con una alimentacion: " + Tipoalimentacion);
        }
        
    }
    class Perro : Mamifero
    {
        protected string nombre;
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
        public Perro(string especienu,string tipoalimentacionnu,string nombrenu):  base(especienu,tipoalimentacionnu,nombrenu)
        {
            Nombre = nombrenu;
            Console.WriteLine("esta es la clase perro con el nombre del perro: " + Nombre);
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
                Perro p = new Perro("canino","carnivoros","chompi");
                Console.ReadKey();
        }
    }
}
