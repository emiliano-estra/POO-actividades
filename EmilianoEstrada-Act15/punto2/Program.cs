using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class NaveEspacial
    {
        private string nombre;
        public NaveEspacial()
        {
            Console.WriteLine("ingrese el nombre de la nave:");
            nombre=Console.ReadLine();
        }
        public string Nombre()
        {
            return nombre;
        }
    }
    class puertocontrol
    {
        private NaveEspacial[] nave;
        private double[][] pesocontenedores;
        public puertocontrol()
        {
            string linea;
            nave = new NaveEspacial[3];
            pesocontenedores = new double[3][];
            for (int i = 0; i < 3; i++) {
                nave[i]=new NaveEspacial();
                Console.WriteLine("ingrese cuantas contenedores tiene la nave "+i+": ");
                linea = Console.ReadLine();
                pesocontenedores[i]=new double[int.Parse(linea)];
                for (int j = 0; j < pesocontenedores[i].Length; j++)
                {
                    Console.WriteLine("ingrese el peso del contenedor " + j + ":");
                    linea = Console.ReadLine();
                    pesocontenedores[i][j] = double.Parse(linea);
                }

            }
        }
        public void pesodetalle()
        {
            for (int i = 0; i < pesocontenedores.Length; i++) {
                Console.Write("la nave " + nave[i].Nombre()+"\n");
                for (int j = 0; j < pesocontenedores[i].Length; j++) {
                    Console.Write(pesocontenedores[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        public void mayorpeso()
        {
            double pesomax = pesocontenedores[0][0];
            string nombre = nave[0].Nombre();
            for (int i = 0; i < pesocontenedores.Length; i++)
            {
                for (int j = 0; j < pesocontenedores[i].Length; j++)
                {
                    if (pesomax < pesocontenedores[i][j])
                    {
                        pesomax=pesocontenedores[i][j];
                        nombre = nave[i].Nombre();
                    }
                }
                if (i == 2)
                {
                    Console.WriteLine("la nave " + nombre+ " tiene el mayor peso individual con "+pesomax);
                }
            }
        }
        public void pesominimototal()
        {
            double[] suma ;
            suma= new double[3];
            double minimo=0;
            int indice = 0;
            for (int i = 0; i < pesocontenedores.Length; i++)
            {
                for (int j = 0; j < pesocontenedores[i].Length; j++)
                {
                    suma[i] = suma[i] + pesocontenedores[i][j];
                }
            }
            minimo = suma[0];
            for (int e = 0; e < pesocontenedores.Length; e++) {
                
                if (minimo > suma[e])
                {
                    minimo = suma[e];
                    indice = e;
                }
                if(e == 2)
                {
                    Console.WriteLine("la nave espacial " + nave[indice].Nombre()+" tiene el peso total menor al resto con "+ minimo);
                }
            }
        }
        static void Main(string[] args)
        {/*Una estación de acoplamiento registra el peso de los contenedores transportados en las
        bodegas de carga de las naves espaciales que llegan al puerto.
        ● Crear la clase NaveEspacial que contenga únicamente el atributo privado
        NombreNave y su constructor para cargarlo.
        ● Crear la clase colaboradora PuertoControl que contenga:
        ○ Un vector de 3 objetos de la clase NaveEspacial.
        ○ Una matriz irregular de tipo double llamado pesoContenedores, donde
        cada fila representa a una nave, el tamaño de la fila es la cantidad de
        bodegas que posee esa nave, y los valores almacenados son los pesos (en
        toneladas) de los contenedores que transporta cada bodega.

        En PuertoControl, definir los siguientes métodos:

        1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
        cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
        irregular) y cargue el peso del contenedor asignado a cada bodega.
        2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
        espacial.
        3. Un método que identifique e informe qué nave transporta el contenedor individual
        más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
        irregular).
        4. Un método que indique el nombre de la nave que transporta menor peso acumulado
        total (la suma de todos sus contenedores).*/
            puertocontrol p= new puertocontrol();
            p.pesodetalle();
            p.mayorpeso();
            p.pesominimototal();
            Console.ReadKey();
        }
    }
}
