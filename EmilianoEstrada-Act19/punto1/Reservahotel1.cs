using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    partial class Reservahotel
    {
        protected string nombrecliente, tipohabitacion;
        protected int cantidadnoches;
        public string Nombrecliente
        {
            set
            {
                nombrecliente = value;
            }
            get
            {
                return nombrecliente;
            }
        }
        public string Tipohabitacion
        {
            set
            {
                tipohabitacion = value;
            }
            get
            {
                return tipohabitacion;
            }
        }
        public int Cantidadnoches
        {
            set
            {

                cantidadnoches = value;
            }
            get
            {
                return cantidadnoches;
            }
        }
        public Reservahotel()
        {
            string linea;
            bool v = true;
            Console.WriteLine("ingrese el nombre del hospedante: ");
            Nombrecliente=Console.ReadLine();
            Console.WriteLine("ingrese que tipo de habitacion se va a quedar: ");
            linea = Console.ReadLine();
            if(linea == "suite" || linea == "doble" ) 
            {
                Tipohabitacion=linea;
            }
            else if (linea == "simple")
            {
                Tipohabitacion = linea;
            }
            else
            {
                while (v)
                {
                    Console.WriteLine("ingrese que tipo de habitacion se va a quedar (suite,doble,simple): ");
                    linea= Console.ReadLine();
                    if (linea == "suite" || linea == "doble")
                    {
                        Tipohabitacion = linea;
                        v = false;
                    }
                    else if(linea == "simple")
                    {
                        Tipohabitacion = linea;
                        v = false;
                    }
                }
            }
            Console.WriteLine("ingrese la cantidad de noche que se va a quedar: ");
            linea = Console.ReadLine();
            if (int.Parse(linea)>0)
            {
               Cantidadnoches = int.Parse(linea);
            }
            else
            {
                while (v)
                {
                    Console.WriteLine("ingrese la cantidad de noche que se va a quedar (numero mayor a cero): ");
                    linea = Console.ReadLine();
                    if (int.Parse(linea)>0)
                    {
                        Cantidadnoches = int.Parse(linea);
                        v = false;
                    }
                }
            }
        }
    }
}
