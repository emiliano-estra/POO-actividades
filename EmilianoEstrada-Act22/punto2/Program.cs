using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class Elementopantalla
    {
        public string nombre;
        public int posx,posy;
        
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
        public int Posx
        {
            set
            {
                posx = value;
            }
            get
            {
                return posx;
            }
        }
        public int Posy
        {
            set
            {
                posy = value;
            }
            get
            {
                return posy;
            }
        }
        public Elementopantalla(){
            string linea;
            Console.Write("ingrese el nombre que quiera poner en la consola: ");
            Nombre=Console.ReadLine();
            Console.Write("\ningrese cuanto espaciado a la derecha quiere ponerlo: ");
            linea = Console.ReadLine();
            Posx=int.Parse(linea);
            Console.Write("\ningrese cuanto tabulado de arriba quiere ponerlo: ");
            linea=Console.ReadLine();
            Posy=int.Parse(linea);
        }
        public void Mostrar()
        {
            Console.SetCursorPosition(Posx,Posy);
            Console.CursorVisible = false;
            Console.WriteLine(Nombre);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
         Implementar propiedades y un constructor que cargue valores.
         Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
        nombre en pantalla y Console.CursorVisible para ocultar el cursor.
         Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
        consola.*/
            Elementopantalla[] t;
            t= new Elementopantalla[4];
            for(int i = 0; i < t.Length; i++) {
            t[i] = new Elementopantalla();
                t[i].Mostrar();
            }
            Console.ReadKey();
        }
    }
}
