using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class socio
    {
       
        private int año;
        private string nombre;
        public socio()
        {
            Console.Write("ingrese el nombre del socio: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese los años del socio: ");
            año = int.Parse(Console.ReadLine());
        }
        public int antiguedad()
        {
            return año;
        }
        public string nombres()
        {
            return nombre;
        }
    }
    class club
    {
        private socio socio1,socio2,socio3;
        private club()
        {
            socio1 = new socio();
            socio2 = new socio();
            socio3 = new socio();
        }
        public void mayor()
        {
           int n=socio1.antiguedad();
           int m=socio2.antiguedad();
           int b=socio3.antiguedad();
            string nom1 = socio1.nombres(), nom2 = socio2.nombres(), nom3 = socio3.nombres();
            if (n > m && n > b)
            {
                Console.Write("el socio con mayor antiguedad es: " + nom1);
            }
            if (m > n && m > b)
            {
                Console.Write("el socio con mayor antiguedad es: " + nom2);
            }
            if (b > n && b > m)
            {
                Console.Write("el socio con mayor antiguedad es: " + nom3);
            }
        }
        static void Main(string[] args)
        {/*Plantear una clase Club y otra clase Socio.
        La clase Socio debe tener los siguientes atributos privados: nombre y la
        antigüedad en el club (en años). En el constructor pedir la carga del nombre y
        su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
        Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
        antigüedad en el club.*/
            club club = new club();
            club.mayor();
            Console.ReadKey();
        }
    }
}
