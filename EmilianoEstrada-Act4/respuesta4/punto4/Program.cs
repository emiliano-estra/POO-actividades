using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  En un banco se procesan datos de las cuentas corrientes de sus clientes.De cada
                cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
                finalizar al ingresar un valor negativo en el número de cuenta.
                Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
                informe:
            a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
            que:
            Estado de la cuenta:
            ○ “Acreedor” si el saldo es &gt; 0.
            ○ “Deudor” si el saldo es &lt; 0.
            ○ “Nulo” si el saldo es = 0.
            b) La suma total de los saldos acreedores.*/
            int num1, numcuenta, suma;
            string linea, total;
            num1 = 0;
            suma = 0;
            total = "";
            do
            {
                Console.Write("ingrese numero de cuenta:");
                linea = Console.ReadLine();
                numcuenta = int.Parse(linea);
                if (numcuenta > 0) {
                    total = total + "el numero de cuenta es:" + linea + "\n ";
                    Console.Write("ingrese su salario:");
                    linea = Console.ReadLine();
                    num1 = int.Parse(linea);
                    total = total + "el salario es:" + linea + "\n ";
                    if (num1 == 0)
                    {
                        total = total + "el estado de cuenta es:Nulo\n \n ";
                    }
                    else 
                    {
                        if (num1 > 0) {
                            total = total + "el estado de cuenta es:Acredor\n\n  ";
                            suma = suma + num1;
                        }
                        else
                        {
                            total = total + "el estado de cuenta es:Deudor\n  ";
                        }

                    }
                    
                }
            }
            while (numcuenta > 0);
            Console.WriteLine(total);
            Console.Write("suma de los acredores:"+suma);
            Console.ReadKey();
        }
    }
}
