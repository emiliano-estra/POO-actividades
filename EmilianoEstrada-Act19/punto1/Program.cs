using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    class Program
    {
        static void Main(string[] args)
        {/*Plantear una clase parcial ReservaHotel.
        En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
        TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
        noches sea mayor a 0. Estos valores son cargados desde la consola.
        En el segundo archivo, agregar un método que calcule el total a pagar según la
        habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
        noche).
        Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.*/
            Reservahotel p, p1, p2;
            p= new Reservahotel();
            p1 = new Reservahotel();
            p2 = new Reservahotel();
            if (p.Calculo() > p1.Calculo() &&p.Calculo()>p2.Calculo()) {
                Console.WriteLine("el hospedante que mas pagara es "+p.Nombrecliente);
            }
            if (p1.Calculo() > p.Calculo() && p1.Calculo() > p2.Calculo())
            {
                Console.WriteLine("el hospedante que mas pagara es " + p1.Nombrecliente);
            }
            if (p2.Calculo() > p1.Calculo() && p2.Calculo() > p.Calculo())
            {
                Console.WriteLine("el hospedante que mas pagara es " + p2.Nombrecliente);
            }
            Console.ReadKey();
            
        }
    }
}
