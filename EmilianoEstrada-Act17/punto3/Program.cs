using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Computadora
    {
        protected string marca;
        protected int memoriaram;
        public string Marca
        {
            set
            {
                marca=value;
            }
            get
            {
                return marca;
            }
        }
        public int Memoriaram
        {
            set
            {
                memoriaram=value;
            }
            get
            {
                return memoriaram;
            }
        }
        public Computadora() {
            Console.WriteLine("ingrese la marca de la computadora: ");
            Marca = Console.ReadLine();
            Console.WriteLine("ingrese cuanta memoria ram tiene la computadora: ");
            memoriaram=int.Parse(Console.ReadLine());
        }
    }
    class Notebook :Computadora
    {
        protected float tamanopantalla;
         public float Tamanopantalla
        {
            set
            {
                tamanopantalla=value;
            }
            get
            {
                return tamanopantalla;
            }
        }
        public Notebook()
        {
            string linea;
            Console.WriteLine("ingrese el tamaño de la pantalla: ");
            linea = Console.ReadLine();
            Tamanopantalla = float.Parse(linea);
        }
       
        public void Mostrarnotebook() {
        Console.WriteLine("la marca de la notebook es "+marca+"\n su memoria RAM es de "+memoriaram+"\n su tamaño de pantalla es de "+tamanopantalla);
        }
    }
    class Escritorio : Computadora
    {
        protected int potenciafuente;
         public int Potenciafuente
        {
            set
            {
                potenciafuente=value;
            }
            get
            {
                return potenciafuente;
            }
        }
        public Escritorio() {
            string linea;
            Console.WriteLine("ingrese la potencia de la fuente: ");
            linea=Console.ReadLine();
            Potenciafuente=int.Parse(linea);
        }
       
        public void Mostrarescritorio()
        {
            Console.WriteLine("la marca de la computadora de escritorio es " + marca + "\n su memoria RAM es de " + memoriaram + "\n su potencia de la fuente es de " + potenciafuente);
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {/*Crear una clase base llamada Computadora que contenga los atributos Marca y
        MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
        Luego, definir dos clases derivadas de la clase base:
         Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
         Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
        Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
        tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
        clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
        de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.*/
            Notebook note = new Notebook();
            note.Mostrarnotebook();
            Escritorio escri = new Escritorio();
            escri.Mostrarescritorio();
            Console.ReadKey();
        }
    }
}
