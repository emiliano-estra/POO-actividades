using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Pelicula
    {
        private string titulo;
        private int duracionminutos, calificaion;
  
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
        public int Duracionminutos
        {
            set {
                duracionminutos = value;
            }
            get
            {
                return duracionminutos;
            }
        }
        public int Calificaion
        {
            set
            {
                if (value < 1 || value > 5)
                {
                    calificaion = 1;
                }
                else
                {
                    calificaion = value;
                }
            }
            get
            {
                return calificaion;
            }
        }
    }
    class Catalogo : Pelicula {
        private Pelicula[] peli;
        public Catalogo()
        {
            string linea;
            bool t = true;
            peli = new Pelicula[3];
            for (int i = 0; i < peli.Length; i++) { 
            peli[i] = new Pelicula();
               
                Console.WriteLine("ingrese el nombre de la pelicula: ");
                peli[i].Titulo = Console.ReadLine();
                Console.WriteLine("ingrese la duracion de la pelicula: ");
                linea = Console.ReadLine();
                if (int.Parse(linea) < 0)
                {
                    while (t)
                    {
                        Console.WriteLine("ingrese la duracion de la pelicula(la duracion tiene que ser mayor a cero): ");
                        linea = Console.ReadLine();
                        if (int.Parse(linea) > 0)
                        {
                            peli[i].Duracionminutos = int.Parse(linea);
                            t = false;
                        }
                    }
                }
                else
                {
                    peli[i].Duracionminutos = int.Parse(linea);
                }
                Console.WriteLine("ingrese la calificacion de la pelicula");
                linea = Console.ReadLine();
                peli[i].Calificaion = int.Parse(linea);
            }
        }
        public int Mayormenor()
        {
            int[] orden,indice;
            orden =new int[3];
            indice = new int[3];
            orden[0] = peli[0].Duracionminutos;
            orden[1] = peli[1].Duracionminutos;
            orden[2] = peli[2].Duracionminutos;
            Array.Sort(orden);
            for (int j = 0; j < orden.Length; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (orden[j] == peli[i].Duracionminutos)
                    {
                        indice[j] = i;
                    }
                }
            }
                Console.WriteLine("peliculas ordenadas de mayor a menor");
            for (int i = 2; i > -1; i--) {
                Console.WriteLine("nombre de la pelicula:"+peli[indice[i]].Titulo+". Duracion:" + orden[i]);
                }
            return orden[0];
        }
        public void Mejor()
        {
            int mejor = peli[0].Calificaion,indice=0;
            for (int i = 0; i < peli.Length; i++) {
                if (mejor < peli[i].Calificaion)
                {
                    mejor = peli[i].Calificaion;
                    indice = i;
                }
            }
            Console.WriteLine("la pelicula mejor calificada es: " + peli[indice].Titulo+" con un "+mejor+"/5");
        }
        public void Corta()
        {
            int corta = Mayormenor(), indice=0;
            for (int i = 0; i < peli.Length; i++) { 
            if(corta== peli[i].Duracionminutos)
                {
                    indice = i;
                }
            }
            Console.WriteLine("la pelicula mas corta es:" + peli[indice].Titulo + " con una duracion de " + corta);
        }
    
    }
    class Prueba
    {
        static void Main(string[] args)
        {/*Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
        La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
        (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
        asegurando mediante validaciones lógicas que:
         La duración en minutos sea estrictamente mayor a cero (0).
         La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
        un valor por defecto de 1).
        La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
        la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
        películas ordenadas de mayor a menor en base a su duración. Además, el método debe
        informar el título de la película con mejor calificación y cuál es la película más corta del
        catálogo.*/
            Catalogo cata = new Catalogo();
            cata.Mejor();
            cata.Corta();
            Console.ReadKey();

        }
    }
}
