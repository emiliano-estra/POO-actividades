using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados
            iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad.*/
           int lado1,lado2,lado3,cant_triangulo,equilatero,isoceles,escaleno;
           string linea;
            Console.WriteLine("ingrese la cantidad de triangulos:");
            linea = Console.ReadLine();
            cant_triangulo = int.Parse(linea);
            equilatero = 0;
            isoceles = 0;
            escaleno = 0;
            for (int i = 0; i < cant_triangulo; i++) { 
             Console.WriteLine("ingrese el primer lado:");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);
                Console.WriteLine("ingrese el segundo lado:");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);
                Console.WriteLine("ingrese el trecer lado:");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);
                if (lado1 == lado2 && lado1 == lado3) {
                    Console.WriteLine("es un triangulo equilatero\n");
                    equilatero++;
                }
                else if((lado1 == lado2 && lado1!=lado2)||(lado1==lado3 && lado1!=lado2)||(lado2==lado3 && lado2!=lado1))
                {
                    Console.WriteLine("es un triangulo isoseles\n");
                    isoceles++;
                }
                else
                {
                    Console.WriteLine("es un escaleno\n");
                    escaleno++;
                }
            }
            if (equilatero < isoceles && equilatero < escaleno) {
                Console.WriteLine("hay menos triangulos equilatero");
            }
             else if (isoceles < equilatero && isoceles < escaleno)
            {
                Console.WriteLine("hay menos triangulos isoceles");
            }
            else if (escaleno < isoceles && escaleno < equilatero)
            {
                Console.WriteLine("hay menos triangulos escaleno");
            }
            Console.WriteLine("hay "+equilatero+" equilatero");
            Console.WriteLine("hay " + isoceles + " isoceles");
            Console.WriteLine("hay " + escaleno + " escaleno");
            Console.ReadKey();
        }
    }
}
