using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Persona
    {
        protected string nombre;
        protected int edad;
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
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("nombre:"+nombre+"\n edad:"+edad);
        }
        
    }
    class Empleado : Persona 
    {
        protected float sueldo;
        public float Sueldo
        {
            set 
            {
            sueldo = value;
            }
            get 
            { 
            return sueldo;
            }
        }
        public void Imprimir1()
        {
            Console.WriteLine("sueldo:"+sueldo);
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {/*Confeccionar una clase Persona que tenga como atributos el nombre y la
        edad (definir las propiedades para poder acceder a dichos atributos). Definir
        un método para imprimirlos. Plantear una segunda clase Empleado que
        herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
        método para imprimir su sueldo. Definir un objeto de la clase Persona y
        llamar a sus métodos y propiedades. También crear un objeto de la clase
        Empleado y llamar a sus métodos y propiedades.*/
            Empleado empl= new Empleado();
            empl.Nombre = "santino";
            empl.Edad = 25;
            empl.Sueldo = 250000.9f;
            empl.Imprimir();
            empl.Imprimir1();
            Console.ReadKey();
        }
    }
}
