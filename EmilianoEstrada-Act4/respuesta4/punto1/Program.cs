using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            $500, realizar un programa que lea los sueldos que cobra cada empleado e
            informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
            de $300.Además el programa deberá informar el importe que gasta la empresa
            en sueldos al personal.*/
            int sueldo, cantempl, num1,emple100_o_300,emple_mayor_300;
            string linea;

            Console.Write("cantidad de empleados que hay en la empresa:");
            linea = Console.ReadLine();
            cantempl = int.Parse(linea);
            num1 = 0;
            emple100_o_300 = 0;
            emple_mayor_300 = 0;
            while (num1 < cantempl) {
                Console.Write("ingrese el suledo entre 100 y 500:");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);
                
                if (sueldo >= 100 && sueldo <= 300 ) {
                    emple100_o_300 = emple100_o_300 + 1;
                }
                else
                {
                    if (sueldo >= 100) {
                        emple_mayor_300++;
                    }
                    else
                    {

                    }
                }
                num1++;
            }
            Console.WriteLine("hay esta cantidad de empleados con un sueldo entre 100 y 300:"+emple100_o_300);
            Console.WriteLine("hay esta cantidad de empleados con un sueldo mayor a 300:" + emple_mayor_300);
            Console.ReadKey();
        }
    }
}
