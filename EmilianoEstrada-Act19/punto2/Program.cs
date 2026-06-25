using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {/*Crear una clase parcial Libro.
        En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
        cantidad de páginas sea mayor a 10. Valores cargados desde consola
        En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
        si el libro es corto (menos de 100 páginas) o largo.
        Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.*/
            Libro l = new Libro();
            Libro y = new Libro();
            l.Resumen();
            y.Resumen();
            Console.ReadKey();
        }
    }
}
