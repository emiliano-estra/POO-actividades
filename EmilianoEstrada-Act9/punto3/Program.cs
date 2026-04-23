using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class atletas
    {
        private string[] atleta;
        private float[] tiempo;
        public void carga()
        {
            string linea;
            atleta = new string[5];
            tiempo = new float[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("ingrese el nombre del atleta: ");
                linea = Console.ReadLine();
                atleta[i]=linea;
                Console.Write("ingrese el tiempo del atleta en una carrera de 100 metros (se escribe con como ): ");
                linea= Console.ReadLine();
                tiempo[i]=float.Parse(linea);
            }
        }
        public void imprimir()
        {
            float baja=0, alta=0, promedio=0;
            int cant = 0;
            alta = calcular_mayor();
            baja = calcular_menor();
            promedio=calcular_promedio();
            Console.WriteLine("el tiempo promedio es: "+promedio);
            Console.WriteLine("el atleta con mejor tiempo es: "+baja);
            Console.WriteLine("el atleta con el peor tiempo es: "+alta);
            for (int i = 0; i < 5; i++) {
                if (promedio > tiempo[i])
                {
                    cant++;
                }
            }
            if (cant < 2) {
                Console.WriteLine("el atleta supero el promedio es: ");
            }
            else
            {
                Console.WriteLine("los atletas superaron el promedio son: ");
            }
            for (int i = 0; i < 5; i++) {
                if (promedio > tiempo[i])
                {
                    Console.WriteLine(atleta[i]);
                }
            }
                
        }
        public float calcular_mayor()
        {
            float mayor = 0;
            for (int i = 0; i < atleta.Length; i++)
            {
                if (mayor < tiempo[i])
                {
                    mayor = tiempo[i];
                }
            }
            return mayor;
        }
        public float calcular_menor()
        {
            float menor = tiempo[0];
            for (int i = 1; i < atleta.Length; i++)
            {
                if (menor > tiempo[i])
                {
                    menor = tiempo[i];
                }
            }
            return menor;
        }
        public float calcular_promedio()
        {
            float promedio=0;
            for(int i = 0;i<atleta.Length;i++)
            {
                promedio = promedio + tiempo[i];
                if (i == 4)
                {
                    promedio = promedio / 5;
                }
            }
            return promedio;
        }
        static void Main(string[] args)
        {
            /*Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
            carrera de 100 metros. El programa debe cargar los datos en dos vectores
            paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
            atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
            promedio.*/
            atletas tiempo=new atletas();
            tiempo.carga();
            tiempo.imprimir();
            Console.ReadKey();
        }
    }
}
