using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    class Dron
    {
        private string codigo; 
        private int nivelbateria; 
        public string Codigo
        {
            set {
                codigo = value; 
            }
            get
            {
                return codigo;
            }
        }
        public int Nivelbateria {
            set 
            {
                nivelbateria = value; 
            } 
            get 
            {
                return nivelbateria; 
            } 
        }
        public Dron(string codigo, int nivelbateria)
        {
            Codigo = codigo; Nivelbateria = nivelbateria; 
        }
    }
    class Centrocontrol
    {
        List<Dron> d = new List<Dron>();
        Dron c; 
        public Centrocontrol()
        {
            for (int i = 0; i < 4; i++)
            {
                bool v=true;
                string codigo, linea; 
                int nivelbateria;
                Console.WriteLine("ingrese el codigo del dron: "); 
                codigo = Console.ReadLine(); 
                Console.WriteLine(" ingrese el nivel debateria: "); 
                linea = Console.ReadLine(); 
                if(int.Parse(linea) < 0 || int.Parse(linea)>100)
                {
                    while (v)
                    {
                        Console.WriteLine("ingrese el nivel de bateria(el minimo es 0 y el maximo es 100): ");
                        linea = Console.ReadLine();
                        if(int.Parse(linea)>0 && int.Parse(linea) < 100)
                        {
                            v=false;
                        }
                    }
                }
                nivelbateria = int.Parse(linea); 
                c = new Dron(codigo, nivelbateria);
                d.Add(c);
            }
        }
        public void Listarflota() 
        { 
            foreach (Dron l in d) { 
              Console.WriteLine("codigo del dron "+l.Codigo+" nivel de bateria "+l.Nivelbateria+" \n"); 
            } 
        }
        public void Removerdronesbajos()
        {
            foreach (Dron k in d)
            {
                if (k.Nivelbateria < 16)
                {
                    Console.WriteLine("el dron " + k.Codigo +" nescesita mantenimiento\n");
                }
            }
            d.RemoveAll(n=>n.Nivelbateria<16);
        } 
        public void Mostrardronesrestantes()
        {
            foreach (Dron l in d)
            {
                Console.WriteLine("codigo del dron " + l.Codigo + " nivel de bateria " + l.Nivelbateria +"\n"); 
            } 
            Console.WriteLine("la cantidad de drones operativos esde "+d.Count); 
        } 
    }
    internal class Program { 
        static void Main(string[] args) {
            /*Una empresa de logística autónoma monitorea el estado y nivel de batería de sus drones de entrega en vuelo de regreso a la base. 
             *  Crear la clase Dron que contenga los atributos privados: codigo (string) y nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
             * Su constructor debe recibir cod y bat.  Crear la clase CentroControl que administre una lista de objetos ListDron.  Métodos en CentroControl:
             * 1. Un constructor que cargue por teclado una lista inicial de 4 drones ingresando sus códigos y baterías. 
             * 2. ListarFlota(): Mostrar la lista de drones en pantalla. 
             * 3. RemoverDronesBajos(): Recorrer la lista y remover por completo de la flota a todos
             * aquellos drones cuyo nivel de batería sea menor o igual al 15% (ya que requieren mantenimiento automático urgente). 
             * 4. MostrarDronesRestantes(): Imprimir la flota actualizada y la cantidad de drones operativos utilizando la propiedad .Count.*/ 
            Centrocontrol c=new Centrocontrol();
            c.Listarflota();
            c.Removerdronesbajos();
            c.Mostrardronesrestantes(); 
            Console.ReadKey(); 
        } 
    }
}
