using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Personagimnasio
    {
        private string nombre;
        private int dni;
        public string Nombre{
            set
            {
                nombre = value;
            }
            get 
            { 
                return nombre; 
            }
        }
        public int DNI
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("nombre de la persona:"+nombre+", DNI de la persona:"+dni);
        }
        
    }
    class Profesor : Personagimnasio
    {
        private string especialidad;

        public string Especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }
        public void ImprimirP()
        {
            Console.WriteLine("especialidad del profesor: "+especialidad+".El nombre del entrenado es: "+Nombre+", DNI del entrenado es: "+DNI);
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {/*Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
        Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
        método para imprimir estos datos básicos.
        Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
        un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
        para imprimir todos los datos del profesor (incluyendo los heredados).
        En el programa principal (Main):
         Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
        llamar a su método de impresión.
         Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
        que puede acceder tanto a sus métodos propios como a los de la clase base.*/
            Personagimnasio persona = new Personagimnasio();
            persona.Nombre = "ignacio";
            persona.DNI = 48909120;
            persona.Imprimir();
            Profesor profesor = new Profesor();
            profesor.Nombre = "santino";
            profesor.DNI = 48505967;
            profesor.Especialidad = "especialista en espalda";
            profesor.Imprimir();
            profesor.ImprimirP();
            Console.ReadKey();
        }
    }
}
