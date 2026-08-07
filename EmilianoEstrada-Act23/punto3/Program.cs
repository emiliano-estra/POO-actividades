using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    class Monitoreocostero
    {
        List<string> especiesdetectadas= new List<string>();
        public void Cargaavistamientos()
        {
            bool e = true;
            string linea;
            while (e) {
                Console.WriteLine("ingrese la especie marina detectada(FIN termina la carga de datos): ");
                linea = Console.ReadLine();
                if (linea == "FIN")
                {
                    e= false;
                }
                else
                {
                    especiesdetectadas.Add(linea);
                }
            }
        }
        public void Mostrarreporteordenado()
        {
            especiesdetectadas.Sort();
            Console.WriteLine("lista de especies en orden alfabetico: ");
            foreach (string v in especiesdetectadas)
            {
                Console.WriteLine(v);
            }
        }
        public void Mostrarreporteinvertido() { 
        especiesdetectadas.Reverse();
            Console.WriteLine("lista de especies en orden inverso alfabetico: ");
            foreach (string v in especiesdetectadas)
            {
                Console.WriteLine(v);
            }
        }
        public void Buscarespecie()
        {
            string linea,nombre;
            Console.WriteLine("ingrese el nombre de la especie: ");
            linea= Console.ReadLine();
            nombre=especiesdetectadas.Find(n => n.Contains(linea));
            if (nombre==linea)
            {
                Console.WriteLine("la especie fue avistada");
            }
            else
            {
                Console.WriteLine("no fue avistada");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Un centro de conservación marina registra de forma dinámica las especies de
        mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
         Crear la clase MonitoreoCostero que contenga como atributo privado
        una lista de cadenas de texto List&lt;string&gt; especiesDetectadas.
         Métodos en MonitoreoCostero:
        1. CargarAvistamientos(): Solicitar por teclado nombres de
        especies marinas avistadas (ej: &quot;Ballena Franca&quot;, &quot;Lobo Marino&quot;,
        &quot;Delfín&quot;) y agregarlos a la lista utilizando .Add(). La carga finaliza
        cuando el usuario ingresa la palabra &quot;FIN&quot;.
        2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
        organizada alfabéticamente de la A a la Z utilizando el método
        .Sort().
        3. MostrarReporteInvertido(): Imprimir la lista organizada de la
        Z a la A combinando .Sort() con el método .Reverse().
        4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
        animal y, utilizando los métodos de búsqueda de listas, informar si la
        especie fue divisada en la costa durante el día.*/
            Monitoreocostero m=new Monitoreocostero();
            m.Cargaavistamientos();
            m.Mostrarreporteordenado();
            m.Mostrarreporteinvertido();
            m.Buscarespecie();
            Console.ReadKey();
        }
    }
}
