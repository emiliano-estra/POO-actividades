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
        public Animal(string es,string ti,string no) 
        {
            Especie = es;
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
        public Mamifero(string es,string ti,string no) : base(es,ti,no)
        {
            Tipoalimentacion = ti;
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
        public Perro(string es,string ti,string no):  base(es,ti,no)
        {
            Nombre = no;
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
                Perro perro = new Perro("canino","carnivoros","chompi");
                Console.ReadKey();
        }
    }
}
