
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class empleado
    {
        private string nombre;
        private int sueldo;
        private empleado() {
            Console.Write("ingrese el nombre del empleado: ");
            nombre=Console.ReadLine();
            Console.Write("ingrese el sueldo del empleado: ");
            string linea=Console.ReadLine();
            sueldo=int.Parse(linea);
        }
        public void imprimir()
        {
            Console.Write("los datos del empleados son: "+nombre+" tiene de sueldo "+sueldo);
            Console.WriteLine();
        }
        public void impuestos()
        {
            if (sueldo > 3000)
            {
                Console.Write("debe pagar impuestos");
            }
            else
            {
                Console.Write("no debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {/*Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. En el constructor cargar los atributos y luego en otro
        método imprimir sus datos y por último uno que imprima un mensaje si debe
        pagar impuestos (si el sueldo supera a 3000)*/
            empleado empleado = new empleado();
            empleado.imprimir();
            empleado.impuestos();
            Console.ReadKey();
        }
    }
}
