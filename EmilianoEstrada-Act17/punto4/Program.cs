using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Material
    {
        protected string tipomaterial;
        public Material() {
            Console.WriteLine("constructor de la clase Material ejecutado");
        }
        public string Tipomaterial
        {
            set
            {
                tipomaterial=value;
            }
            get
            {
                return tipomaterial;
            }
        }
       
    }
    class Herramienta : Material
    {
        protected string funcionprincipal;
        public Herramienta() {
            Console.WriteLine("constructor de la clase Herramienta ejecutado");
        }
        public string Funcionprincipal
        {
            set
            {
                funcionprincipal = value;
            }
            get
            {
                return funcionprincipal;
            }
        }
    }
    class Martillo : Herramienta {
        protected double pesogramos;
        public Martillo()
        {
            Console.WriteLine("constructor de la clase Martillo ejecutado");
        }
        public double Pessogramos
        {
            set
            {
                pesogramos = value;
            }
            get
            {
                return pesogramos;
            }
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {/*Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
        herencia: Material, Herramienta y Martillo.
         La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
        Plástico).
         La clase Herramienta (que hereda de Material) debe añadir el atributo
        FuncionPrincipal.
         La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
        Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
        correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
        acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
        (ejemplo: &quot;Constructor de la clase Material ejecutado&quot;).
        En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
        parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
        en cadena de los constructores (desde la raíz hasta la clase derivada).*/
            Martillo martillo = new Martillo();
            martillo.Tipomaterial = "acero";
            martillo.Funcionprincipal = "carpinteria";
            martillo.Pessogramos= 2500.6;
            Console.ReadKey();
        }
    }
}
