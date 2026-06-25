using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    partial class Libro
    {
        protected string titulo, autor;
        protected int paginas;
        public string Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }
        public string Autor
        {
            set
            {
                autor = value;
            }
            get
            {
                return autor;
            }
        }
        public int Paginas
        {
            set
            {
                paginas = value;
            }
            get
            {
                return paginas;
            }
        }
        public Libro()
        {
            string linea;
            bool t = true;
            Console.WriteLine("ingrese el nombre del libro: ");
            Titulo = Console.ReadLine();
            Console.WriteLine("ingrese el nombre del autor: ");
            Autor = Console.ReadLine();
            Console.WriteLine("ingrese la cantidad de paginas del libro: ");
            linea = Console.ReadLine();
            while (t)
            {
                Console.WriteLine("ingrese la cantidad de paginas del libro (tiene que ser mayor a 10): ");
                linea = Console.ReadLine();
                if (int.Parse(linea) > 10)
                {
                    Paginas = int.Parse(linea);
                    t = false;
                }
            }
        }
    }
}