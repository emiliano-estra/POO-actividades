using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    class Documento
    {
        private string nombrearchivo;
        private int cantidadpaginas;
        public string Nombrearchivo
        {
            set
            {
                nombrearchivo = value;
            }
            get
            {
                return nombrearchivo;
            }
        }
        public int Cantidadpaginas
        {
            set
            {
                cantidadpaginas = value;
            }
            get
            {
                return cantidadpaginas;
            }
        }
        public Documento()
        {
            string linea;
            Console.Write("ingrese el nombre del archivo: ");
            Nombrearchivo = Console.ReadLine();
            Console.Write("\n ingrese la cantidad de paginas: ");
            linea = Console.ReadLine();
            Cantidadpaginas = int.Parse(linea);
        }
    }
    class Servidorimpresion
    {
        List<Documento> cv = new List<Documento>();
        public void Agregardocumento(Documento d)
        {
            cv.Add(d);
        }
        public void Imprimirsiguiente(Documento d)
        {
            if (cv.Count > 0)
            {
                Console.Write("el nombre del archivo impreso " + cv[0].Nombrearchivo + " tienen una cantidad de hojas " + cv[0].Cantidadpaginas);
                cv.RemoveAt(0);
            }
            else
            {
                Console.Write("\n no hay impresiones pendientes");
            }
        }
        public void Mostrarcolapendinetes()
        {
            int numero = 0;
            foreach (Documento d in cv)
            {
                Console.WriteLine("\n" + d.Nombrearchivo + "\n");
                numero = numero + d.Cantidadpaginas;
            }
            Console.Write("\nhay " + numero + " impresiones de hojas pendientes\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
         llegada.
          Crear la clase Documento que contenga como atributos privados:
         nombreArchivo (string) y cantidadPaginas (int). Definir sus
         propiedades de solo lectura y un constructor que reciba los parámetros nom
         y pag.
          Crear la clase ServidorImpresion que administre una lista dinámica de
         documentos (List<Documento>).
          Métodos en ServidorImpresion:
         1. AgregarDocumento(): Solicitar por teclado los datos de un
         documento y agregarlo al final de la lista utilizando .Add().
         2. ImprimirSiguiente(): Si la lista no está vacía, simular la
         impresión del primer documento de la lista (mostrar sus datos en
         consola) y removerlo de la colección mediante .RemoveAt(0). Si está
         vacía, advertir que no hay trabajos pendientes.
         3. MostrarColaPendiente(): Listar todos los documentos que
         están esperando ser impresos y la cantidad total de páginas
         acumuladas en la cola de espera utilizando .Count.*/
            Servidorimpresion s = new Servidorimpresion();
            for (int i = 0; i < 5; i++)
            {
                Documento d = new Documento();
                if (i == 3)
                {
                    s.Agregardocumento(d);
                    d = new Documento();
                    s.Agregardocumento(d);
                    d = new Documento();
                    s.Agregardocumento(d);
                    s.Imprimirsiguiente(d);
                    s.Mostrarcolapendinetes();
                }
                else
                {
                    s.Agregardocumento(d);
                    s.Imprimirsiguiente(d);
                    s.Mostrarcolapendinetes();
                }
            }
            Console.ReadKey();

        }
    }
}
