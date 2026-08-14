using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    class Estudiante
    {
        private string nombrecompleto;
        private double calificacion;
        public string Nombrecompleto
        {
            set
            {
                nombrecompleto = value;
            }
            get
            {
                return nombrecompleto;
            }
        }
        public double Calificacion
        {
            set
            {
                calificacion = value;
            }
            get
            {
                return calificacion;
            }
        }
        public Estudiante(string nombre,double calificacion) {
            Nombrecompleto = nombre;
            Calificacion = calificacion;
        }
    }
    class Gestionacademica
    {
        List<Estudiante> e = new List<Estudiante>();
        public void Cargaestudiantes()
        {
            bool t = true;
            while (t) {
                string linea,nombre;
                double calificacion;
                Console.WriteLine("ingrese el nombre completo del estudiante: ");
                nombre= Console.ReadLine();
                if (nombre == "FIN")
                {
                    t= false;
                }
                else
                {
                    Console.WriteLine("ingrese la calificacion del estudiante: ");
                    linea = Console.ReadLine();
                    calificacion=double.Parse(linea);
                    Estudiante b = new Estudiante(nombre,calificacion);
                    e.Add(b);
                }
            }
        }
        public void Listarestudiantes()
        {
            Console.WriteLine("lista de alumnos: ");
            foreach (Estudiante n in e)
            {
                Console.WriteLine(n.Nombrecompleto);
            }
            Console.WriteLine("la cantidad de alumnos inscriptos: "+e.Count);
        }
        public void Filtraraprobados()
        {
            foreach(Estudiante y in e)
            {
                if (y.Calificacion > 6.0)
                {
                    Console.WriteLine("el estudiante "+y.Nombrecompleto+" aprobo con una de "+y.Calificacion);
                }
            }
        }
        public void Dardebaja()
        {
            Estudiante nombre;
            string linea;
            Console.WriteLine("ingrese el nombre del estudiante que quiera dar de baja: ");
            linea= Console.ReadLine();
            nombre=e.Find(x=>x.Nombrecompleto==linea);
            e.Remove(nombre);
            Console.WriteLine("\nlista de alumnos: ");
            foreach (Estudiante n in e)
            {
                Console.WriteLine(n.Nombrecompleto);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
        realizar el seguimiento académico de sus materias.
         Crear la clase Estudiante que contenga como atributos privados:
        nombreCompleto (string) y calificacion (double). Definir sus propiedades
        de solo lectura y un constructor que reciba nom y cal.
         Crear la clase GestionAcademica que administre una lista de objetos
        List.
         Métodos en GestionAcademica:
        o CargarEstudiantes(): Solicitar por teclado nombres y
        calificaciones para agregar estudiantes a la lista mediante .Add(). La
        carga finaliza cuando el usuario ingresa la palabra FIN como nombre.
        o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
        junto a la cantidad total de inscriptos mediante la propiedad .Count.
        o FiltrarAprobados(): Recorrer la lista e imprimir en consola
        únicamente aquellos estudiantes cuya calificación sea mayor o igual
        a 6.0.
        o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
        utilizando los métodos de búsqueda y remoción de listas, eliminarlo
        de la colección si se encuentra presente.*/
            Gestionacademica g=new Gestionacademica();
            g.Cargaestudiantes();
            g.Listarestudiantes();
            g.Filtraraprobados();
            g.Dardebaja();
            Console.ReadKey();
        }
    }
}
