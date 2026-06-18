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
        public void carga()
        {
            criatura=new Criaturamarina[3];
            for(int i = 0; i < 3; i++) {
                criatura[i]=new Criaturamarina();
            }
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
            Console.ReadKey();
        }
    }
}
