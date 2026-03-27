using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
     class Plano
    {
        private int x;
        private int y;
        private string eje;
        public void ingresar_numero()
        {
            string linea;
            Console.WriteLine("ingresar el eje x:");
            linea = Console.ReadLine();
            x=int.Parse(linea);
            Console.WriteLine("ingresar el eje y:");
            linea = Console.ReadLine();
            y = int.Parse(linea);
        }

        public void calcular_eje()
        {
            if (x > 0 && y > 0)
            {
                eje = "esta en el primer cuadrante";
            }
            else if (x < 0 && y > 0)
            {
                eje = "esta en el segundo cuadrante";
            }
            else if (x < 0 && y < 0)
            {
                eje = "esta en el tercer cuadrante";
            }
            else if (x > 0 && y < 0) {
                eje = "esta en el cuarto cuadrante";
            }
        }
        public void imprimir()
        {
            Console.Write(eje);
        }
        static void Main(string[] args)
        {
          /*Desarrollar una clase que represente un punto en el plano y tenga los
                siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
                encuentra dicho punto(concepto matemático, primer cuadrante si x e y son
                positivas, si x&lt; 0 e y&gt; 0 segundo cuadrante, etc.)*/
          Plano plano = new Plano();
            plano.ingresar_numero();
            plano.calcular_eje();
            plano.imprimir();
            Console.ReadKey();
        }
    }
}
