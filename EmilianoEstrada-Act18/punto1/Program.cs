using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Dispositivoenergia
    {
        private string codigoidentificador;
        private double generacionkwh;
         public string Codigoidentificador
        {
            set
            {
                codigoidentificador = value;
            }
            get
            {
                return codigoidentificador;
            }
        }
        public double Generacionkwh
        {
            set
            {
                if (value < 0)
                {
                    generacionkwh = 0;
                }
                else
                {
                    generacionkwh = value;
                }
            }
            get
            {
                return generacionkwh;
            }
        }
        public void carga()
        {
            string linea;
            Console.WriteLine("ingrese el codigo de identificador: ");
            Codigoidentificador = Console.ReadLine();
            Console.WriteLine("ingrese la generacion de kWh: ");
            linea = Console.ReadLine();
            Generacionkwh=double.Parse(linea);
        }
        public void imprimir()
        {
            Console.WriteLine("su generacion de kWh es de "+generacionkwh+" siendo el codigo de identificador "+codigoidentificador);
        }
        
    }
    class Panelsolar : Dispositivoenergia
    {
        private double areametros;
         public double Areametros
        {
            set
            {
                    areametros = value;
            }
            get
            {
                return areametros;
            }
        }
        public Panelsolar(){
            string linea;
            bool t = true;
            Console.WriteLine("ingrese el area en metros del dispositivo: ");
            linea = Console.ReadLine();
            if(double.Parse(linea) < 0)
            {
                while (t)
                {
                    Console.WriteLine("ingrese el area en metros del dispositivo (ingrese mas de 0): ");
                    linea= Console.ReadLine();
                    if (double.Parse(linea) > 0)
                    {
                        Areametros=double.Parse(linea);
                        t=false;
                    }
                }
            }
            else
            {
                Areametros = double.Parse(linea);
            }
        }
       
        public void imprimirp()
        {
            Console.WriteLine("su generacion de kWh es de "+Generacionkwh+" siendo el codigo de identificador "+Codigoidentificador+" estando en "+areametros+" metros");
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {/*Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
        CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
        generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
        generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
        imprimir estos datos básicos.
        Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
        un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
        en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
        Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
        En el programa principal (Main):
        ● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
        ● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
        puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
        muestra de información.*/
            Dispositivoenergia d = new Dispositivoenergia();
            d.carga();
            d.imprimir();
            Panelsolar pane = new Panelsolar();
            pane.carga();
            pane.imprimirp();
            Console.ReadKey();
        }
    }
}
