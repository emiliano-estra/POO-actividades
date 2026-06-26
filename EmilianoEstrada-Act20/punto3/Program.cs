using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    class Zonatotal
    {
        private int total;
        private string nombrezona; 
        public int Total
        {
            set
            {
                total = value;
            }
            get 
            {
                return total; 
            }
        }
        public string Nombrezona
        {
            set
            {
                nombrezona=value;
            }
            get
            {
                return nombrezona;
            }
        }
        public Zonatotal(string n, int t)
        {
            Total = t;
            Nombrezona =n;
        }
    }
    class Arqueologia
    {
        private int[,] arqueologia;
        private int[] total;
        private int mayor;
        private List<Zonatotal> tu;
        public Arqueologia(){
            string linea;
            arqueologia = new int[3,4];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 1; j < 5; j++)
                {
                    Console.WriteLine("ingrese cuantos visitantes tuvo la zona "+i+" en la semana "+j+": ");
                    linea=Console.ReadLine();
                    arqueologia[i,j-1]=int.Parse(linea);
                }
            }

        }
        public void Calculartotal()
        {
            total = new int[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    total[i]=arqueologia[i,j]+total[i];
                    if (mayor < total[i])
                    {
                        mayor=total[i];
                    }
                }
            }
        }
        public void Mostrartabular()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("la zona " + i);
                for (int j = 1; j < 5; j++)
                {
                    Console.Write( "  "+ arqueologia[i,j-1]+ "  \n");
                }
            }
        }
        public void Crearlista()
        {
            tu=new List<Zonatotal>();
            string linea;
            for (int i=0;i<3;i++)
            {
                if (i == 0){
                    linea = "zona A";
                }
                if (i == 1)
                {
                    linea = "zona B";
                }
                else
                {
                     linea = "zona C";
                }
                Zonatotal v = new Zonatotal(linea, total[i]);
                tu.Add(v);
            }
        }
        public void Zonamayor()
        {
            foreach(Zonatotal m in tu)
            {
                if (m.Total == mayor) {
                    Console.WriteLine("la zona mas visitada es "+m.Nombrezona+" con "+m.Total+" visitantes");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
        arqueológicas durante 4 semanas.
        Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
        días. Luego:
         Calcular el total de visitas por zona y almacenarlo en un vector.
         Mostrar los datos en forma tabular.
         Agregar estos resultados a una lista llamada zonasVisitadas que contenga
        nombres de zonas y total de visitas.
         Determinar cuál fue la zona más visitada.*/
            Arqueologia cu=new Arqueologia();
            cu.Calculartotal();
            cu.Mostrartabular();
            cu.Crearlista();
            cu.Zonamayor();
            Console.ReadKey();
        }
    }
}
