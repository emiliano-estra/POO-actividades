using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Criaturamarina
    {
        private string especie;
        private int profundidadoptima,niversalinidad;
        public string Especie
        {
            set
            {
                especie = value;
            }
            get 
            {
                return especie; 
            }
        }
        public int Profundidadoptima
        {
            set
            {
                profundidadoptima = value;
            }
            get
            {
                return profundidadoptima;
            }
        }
        public int Niversalinidad
        {
            set
            {
                if(value<1|| value > 100)
                {
                    niversalinidad = 35;
                }
                else
                {
                    niversalinidad=value;
                }
            }
            get
            {
                return niversalinidad;
            }
        }
    }
    class Habitatauatico : Criaturamarina
    {
        public Criaturamarina[] criatura;
        public void Carga()
        {
            string linea;
            bool v = true;
            criatura=new Criaturamarina[3];
            for(int i = 0; i < 3; i++) {
                criatura[i]=new Criaturamarina();
                Console.WriteLine("ingrese la especie maritima: ");
                criatura[i].Especie = Console.ReadLine();
                Console.WriteLine("ingrese la profundidad optima: ");
                linea = Console.ReadLine();
                if (int.Parse(linea) <= 0) {
                    while (v)
                    {
                        Console.WriteLine("ingrese la profundidad optima (que sea mayor a cero): ");
                        linea= Console.ReadLine();
                        if (int.Parse(linea) > 0)
                        {
                            criatura[i].Profundidadoptima = int.Parse(linea);
                            v = false;
                        }
                    }
                }
                else
                {
                    criatura[i].Profundidadoptima = int.Parse(linea);
                }
                Console.WriteLine("ingrese el nivel de sanidad: ");
                linea= Console.ReadLine();
                criatura[i].Niversalinidad=int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            int[] orden, indice;
            orden = new int[3];
            indice = new int[3];
            orden[0] = criatura[0].Profundidadoptima;
            orden[1] = criatura[1].Profundidadoptima;
            orden[2] = criatura[2].Profundidadoptima; 
            Array.Sort(orden);
            for (int j = 0; j < orden.Length; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (orden[j] == criatura[i].Profundidadoptima)
                    {
                        indice[j] = i;
                    }
                }
            }
            for(int t = 0;t < 3; t++)
            {
                Console.WriteLine("la especie " + criatura[indice[t]].Especie +" tiene una profundidad optima de " + orden[t]+" con un nivel de salinidad de " + criatura[indice[t]].Niversalinidad);
            } 
        }
        public void Salinidad()
        {
            int mayor = criatura[0].Niversalinidad, indice=0;
            for (int j = 0; j < 3; j++)
            {
                if (mayor < criatura[j].Niversalinidad)
                {
                    mayor=criatura[j].Niversalinidad;
                    indice=j;
                }
            }
            Console.WriteLine("la especie que necesita mayor salinidad es " + criatura[indice].Especie+" con "+mayor);
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {/*Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
        La clase CriaturaMarina debe tener como atributos privados: Especie (string),
        ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
        propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
        ● La profundidad óptima sea estrictamente mayor a cero (0).
        ● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
        asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
        La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
        de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
        criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
        a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
        nivel de salinidad para sobrevivir.*/
            Habitatauatico h = new Habitatauatico();
            h.Carga();
            h.Imprimir();
            h.Salinidad();
            Console.ReadKey();
        }
    }
}
