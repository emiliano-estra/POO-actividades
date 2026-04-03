using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class operaciones
    {
        private int num1;
        private int num2;
        public void ingresar_numeros()
        {
            string linea;
            Console.Write("ingresar un numero:");
            linea = Console.ReadLine();
            num1=int.Parse(linea);
            Console.Write("ingresar otro numero:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
        }
        public void imprimir_calculos()
        {
            int suma;
            int resta;
            int multiplicacion;
            double division;
            suma = sumar(num1,num2);
            resta = restar(num1,num2);
            multiplicacion = multiplicar(num1,num2);
            division = dividir(num1,num2);
            Console.WriteLine("suma:" + suma);
            Console.WriteLine("resta:" + resta);
            Console.WriteLine("producto:"+ multiplicacion);
            Console.WriteLine("resto:"+division);
        }
        public int sumar(int valor1,int valor2)
        {
            int valortotal;
            valortotal = valor1 + valor2;
            return valortotal;
        }
        public int restar(int valor1,int valor2)
        {
            int sobra;
            sobra = valor1 - valor2;
            return sobra;
        }
        public int multiplicar(int valor1, int valor2)
        {
            int producto;
            producto = valor1 * valor2;
            return producto;
        }
        public double dividir(double valor1, double valor2)
        {
            double resto;
            resto = valor1 / valor2;
            return resto;
        }

        static void Main(string[] args)
        {
            /*Implementar la clase operaciones. Se deben cargar dos valores enteros,
            calcular su suma, resta, multiplicación y división, cada una en un método,
            imprimir dichos resultados.*/
            operaciones calculo = new operaciones();
            calculo.ingresar_numeros();
            calculo.imprimir_calculos();
            Console.ReadKey();
        }
    }
}
