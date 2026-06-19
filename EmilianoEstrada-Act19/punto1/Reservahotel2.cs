using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    partial class Reservahotel
    {
        public int Calculo()
        {
            int valor=0;
            if (Tipohabitacion == "suite")
            {
                 valor = Cantidadnoches * 12000;
                return valor;
            }
            else if (Tipohabitacion =="doble")
            {
                 valor = Cantidadnoches * 8000;
                return valor;
            }
            else
            {
                valor = Cantidadnoches * 5000;
                return valor;
            }
        }
    }
}
