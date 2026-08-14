using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto6
{
    class Libro
    {
        private string titulo;
        private int aniopublicacion;
        public string Titulo
        {
            get
            {
                return titulo;
            }
        }
        public int Aniopublicacion
        {
           
            get
            {
                return aniopublicacion;
            }
        }
        public Libro(string titulo,int anio) { 
        this.titulo = titulo;
        aniopublicacion = anio;
        }
    }
    class Bibliotecacentral
    {
        List<Libro> l=new List<Libro>();
        public void Cargarcatalogo()
        {
            bool e = true;
            string linea,titulo;
            int año;
            while (e)
            {
                Console.WriteLine("ingrese el titulo (FIN termina la carga de datos): ");
                linea = Console.ReadLine();
                
                if (linea == "FIN")
                {
                    e = false;
                }
                else
                {
                    titulo = linea;
                    Console.WriteLine("ingrese el año de publicacion: ");
                    linea= Console.ReadLine();
                    año=int.Parse(linea);
                    Libro t = new Libro(titulo,año);
                    l.Add(t);
                }
            }
        }
        public void Listarcatalogo()
        {
            foreach (Libro t in l)
            {
                Console.WriteLine("Titulo: " + t.Titulo + " Año de publicacion: " + t.Aniopublicacion);
            }
            Console.WriteLine("Cantidad total de obras registradas: " + l.Count);
        }
        public void Filtrarporanio()
        {
            Console.WriteLine("Ingrese un año : ");
            int año = int.Parse(Console.ReadLine());
            foreach (Libro t in l)
            {
                if (t.Aniopublicacion < año)
                {
                    Console.WriteLine("Titulo: " + t.Titulo + " Año de publicacion: " + t.Aniopublicacion);
                }
            }
        }
        public void Removerlibro()
        {
            Console.WriteLine("Ingrese el titulo del libro a eliminar: ");
            string titulo = Console.ReadLine();
            Libro libroAEliminar = l.FirstOrDefault(libro => libro.Titulo == titulo);
            if (libroAEliminar != null)
            {
                l.Remove(libroAEliminar);
                Console.WriteLine("Libro eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró un libro con ese título.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
        para organizar la consulta de ejemplares por parte de los lectores.
         Crear la clase Libro que contenga como atributos privados: titulo
        (string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
        un constructor que reciba tit y anio.
         Crear la clase BibliotecaCentral que administre una lista de objetos
        List.
         Métodos en BibliotecaCentral:
        1. CargarCatalogo(): Solicitar por teclado títulos y años de
        publicación para agregar libros a la lista mediante .Add(). La carga
        finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
        2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
        junto a la cantidad total de obras registradas mediante la propiedad
        .Count.
        3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
        imprimir en consola únicamente aquellos libros cuyo año de
        publicación sea menor a dicho valor.
        4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
        los métodos de búsqueda y remoción de listas, eliminarlo de la
        colección si se encuentra presente.*/
            Bibliotecacentral b = new Bibliotecacentral();
            b.Cargarcatalogo();
            b.Listarcatalogo();
            b.Filtrarporanio();
            b.Removerlibro();
            Console.ReadKey();
        }
    }
}
