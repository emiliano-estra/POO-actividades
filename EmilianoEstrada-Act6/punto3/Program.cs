using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class empleado
    {
        private string nombre;
        private int sueldo;
        public void ingresar_datos()
        {
            string linea;
            Console.Write("ingresar el nombre:");
            nombre = Console.ReadLine();
            Console.Write("ingresar el sueldo:");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }
        public void imprimir_datos()
        {
            Console.WriteLine("su nombre es:" + nombre);
            Console.WriteLine("su sueldo es:" + sueldo);
        }
        public void imprimir_impuestos()
        {
            int impuesto;
            string paga;
            impuesto = calcular_impuestos(sueldo);
            if (impuesto == 0)
            {
                paga = "no debe pagar impuestos";
                Console.WriteLine(paga);
            }
            else {
                paga = "si debe pagar impuestos";
                Console.WriteLine(paga);
            }
            
        }
        public int calcular_impuestos(int num)
        {
            int debe;
            
            if (num > 3000)
            {
                debe = 1;
                return debe;
            }
                debe = 0;
                return debe;
        }

        static void Main(string[] args)
        {
            /*Confeccionar una clase que represente un empleado. Definir como atributos su
            nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
            sus datos y por último uno que imprima un mensaje si debe pagar impuestos
            (si el sueldo supera a 3000).*/
            empleado empleado = new empleado();
            empleado.ingresar_datos();
            empleado.imprimir_datos();
            empleado.imprimir_impuestos();
            Console.ReadKey();
        }
    }
}
