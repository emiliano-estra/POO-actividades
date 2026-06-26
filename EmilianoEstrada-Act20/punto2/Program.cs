using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class Paquete
    {
        public string codigo,destino;
        public double peso;
        public string Codigo
        {
            set
            {
                codigo = value;
            }
            get
            {
                return codigo;
            }
        }
        public double Peso {
            set
            {
                peso = value;
            }
            get
            {
                return peso;
            }
        }
        public string Destino
        {
            set
            {
                destino = value;
            }
            get
            {
                return destino;
            }
        }
        public Paquete(string c, double p, string d)
        {
            Codigo = c;
            Peso = p;
            Destino = d;
        }
    }
    class Despachador
    {
        private List<Paquete> paquetes =new List<Paquete>();
        public void Registrarnuevos()
        {
            for (int l = 0; l < 5; l++)
            {
                double t;
                string e, i, linea;
                Console.WriteLine("ingrese el codigo del paquete: ");
                e = Console.ReadLine();
                Console.WriteLine("ingrese el peso del paquete: ");
                linea = Console.ReadLine();
                t = double.Parse(linea);
                Console.WriteLine("ingrese el destino del paquete: ");
                i = Console.ReadLine();
                Paquete r = new Paquete(e, t, i);
                paquetes.Add(r);
            }
        }
        public void Mostrar()
        {
            int masa = 0, lugar = 0;
            foreach (Paquete p in paquetes)
            {
                Console.WriteLine("el codigo de paquete es "+p.Codigo+" el peso del paquete es "+p.Peso+" el destino es "+p.Destino);
                if (p.Peso > 10)
                {
                    masa++;
                }
                if (p.Destino == "Argentina")
                {
                    lugar++;
                }
            }
            Console.WriteLine("hay "+masa+" paquetes que superar los 10kg \n hay "+lugar+" paquetes con destino nacional");
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {/*Una empresa de envíos desea registrar sus entregas mediante colaboración de
        clases.
        Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
        Despachador que contenga una lista de paquetes y un método para registrar nuevos
        paquetes.
        Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
         Todos los paquetes registrados.
         Cuántos superan los 10 kg de peso.
         Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/
            Despachador yo =new Despachador();
            yo.Registrarnuevos();
            yo.Mostrar();
            Console.ReadKey();
        }
    }
}
