using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    class Dispositivointeligente
    {
        private string nombredispositivo;
        private double consumowatts;
        public string Nombredispositivo
        {
            set
            {
                nombredispositivo = value;
            }
            get
            {
                return nombredispositivo;
            }
        }
        public double Consumowatts
        {
            set
            {
                consumowatts = value;
            }
            get
            {
                return consumowatts;
            }
        }
        public Dispositivointeligente(string nombre,double consumo) {
        Nombredispositivo= nombre;
           Consumowatts= consumo;
        }

    }
    class Paneldomotico
    {
        List<Dispositivointeligente> d=new List<Dispositivointeligente>();
        public Paneldomotico() {
            for(int i = 0; i < 1; i++)
            {
                string nombre, linea;
                double consumo;
                Console.WriteLine("ingrese el nombre del dispositivo: ");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese el consumo en watts: ");
                linea = Console.ReadLine();
                consumo = double.Parse(linea);
                Dispositivointeligente dis=new Dispositivointeligente(nombre,consumo);
                d.Add(dis);
                Console.WriteLine("quiere ingresar otro dispositivo(si o no):");
                linea=Console.ReadLine();
                if (linea == "si")
                {
                    i--;
                }
            }
            
        }
        public void Mostrardispositivos()
        {
            foreach (Dispositivointeligente v in d)
            {
                Console.WriteLine("el dispositivo "+v.Nombredispositivo+" consume "+v.Consumowatts+" Watts");
            }
        }
        public void Calcularconsumototal()
        {
            double total = 0;
            foreach (Dispositivointeligente i in d)
            {
                total=total+i.Consumowatts;
            }
            Console.WriteLine("la casa consume un tatal de "+total+" Watts");
        }
        public void Desconectardispositivo()
        {
            string linea,nombre;
            Console.WriteLine("ingrese el dispositivo que quieras apagar: ");
            linea= Console.ReadLine();
            for(int i=d.Count-1;i>=0;i--) 
            {
                nombre = d[i].Nombredispositivo;
                if (nombre == linea)
                {
                    d.RemoveAt(i);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
            vinculados a una red hogareña.
             Crear la clase DispositivoInteligente que contenga como atributos
            privados: nombreDispositivo (string) y consumoWatts (double). Definir
            sus propiedades y un constructor que reciba nom y watts.
             Crear la clase colaboradora PanelDomotico que administre un objeto
            List&lt;DispositivoInteligente&gt;.
             Métodos en PanelDomotico:
            1. Un constructor que permita al usuario cargar dinámicamente
            dispositivos por teclado. El sistema preguntará después de cada
            carga si se desea agregar otro dispositivo.
            2. MostrarDispositivos(): Listar todos los dispositivos
            configurados junto a sus consumos.
            3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
            Watts totales que consume la casa sumando los valores de la lista.
            4. DesconectarDispositivo(): Solicitar al usuario el nombre de
            un dispositivo y, si existe en la lista, removerlo de forma dinámica
            para simular su apagado remoto.*/
            Paneldomotico p=new Paneldomotico();
            p.Mostrardispositivos();
            p.Calcularconsumototal();
            p.Desconectardispositivo();
            Console.ReadKey();
        }
    }
}
