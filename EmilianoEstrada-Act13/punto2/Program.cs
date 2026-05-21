using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class operaciones
    {
        private int numero1;
        private int numero2;
        private int resultado;
        private operaciones() {
            resultado = 0;
            Console.Write("ingrese uno de los valores: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el otro valor: ");
            numero2 = int.Parse(Console.ReadLine()); 
        }
        public void suma()
        {
            resultado = numero1 + numero2;
            Console.Write(resultado);
            Console.WriteLine();
        }
        public void resta()
        {
            resultado=numero1 - numero2;
            Console.Write(resultado);
            Console.WriteLine();
        }
        public void multiplicaion()
        {
            resultado = numero1 * numero2;
            Console.Write(resultado);
            Console.WriteLine();
        }
        public void division()
        {
            resultado = numero1 / numero2;
            Console.Write(resultado);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {/*Implementar la clase operaciones. Se deben cargar dos valores enteros en el
        constructor, calcular su suma, resta, multiplicación y división, cada una en un
        método, imprimir dichos resultados.*/
            operaciones ope=new operaciones();
            ope.suma();
            ope.resta();
            ope.multiplicaion();
            ope.division();
            Console.ReadKey();
        }
    }
}
