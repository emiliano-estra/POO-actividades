using System;
using System.Collections.Generic;
using System.Linq;
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
        ;
        public Despachador()
        {
           List<Paquete> paquetes = new List<Paquete>();
        }
        public void RegistrarPaquete(Paquete paquete)
        {
            paquetes.Add(paquete);
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
        }
    }
}
