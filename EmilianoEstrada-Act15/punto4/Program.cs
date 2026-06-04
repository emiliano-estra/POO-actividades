using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class RobotEnsamblador
    {
        private string modelo;
        private float[][] tiempoensablaje;
        public RobotEnsamblador()
        {
            string linea;
            Console.WriteLine("ingrese el modelo del robot: ");
            modelo = Console.ReadLine();
            tiempoensablaje = new float[4][];
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese cuantas subtareas tiene la fase "+i+": ");
                linea = Console.ReadLine();
                tiempoensablaje[i]= new float[int.Parse(linea)];
                for(int j = 0; j < tiempoensablaje[i].Length; j++)
                {
                    Console.WriteLine("ingrese el tiempo que tardo en la subtarea "+ j+": ");
                    linea= Console.ReadLine();
                    tiempoensablaje[i][j]=float.Parse(linea);
                }
            }
        }
        public string model()
        {
            return modelo;
        }
        public string tiemposfase()
        {
            string fases = "modelo del robot "+modelo;
            for (int i = 0; i < 4; i++)
            {
                fases += " la fase "+i+" \n";
                for (int j = 0; j < tiempoensablaje[i].Length; j++)
                {
                    fases += "  "+tiempoensablaje[i][j]+" ";
                }
                fases += "\n";
            }
            return fases;
        }
        public float tiempofase1promedio()
        {
            float suma = 0, promedio = 0;
                for (int j = 0; j < tiempoensablaje[0].Length; j++)
                {
                    suma=suma+tiempoensablaje[0][j];
                }
                promedio = suma / tiempoensablaje[0].Length;
       
            return promedio;
        }
        public float tiempofase2promedio()
        {
            float suma = 0, promedio = 0;
            for (int j = 0; j < tiempoensablaje[1].Length; j++)
            {
                suma = suma + tiempoensablaje[1][j];
            }
            promedio = suma / tiempoensablaje[1].Length;

            return promedio;
        }
        public float tiempofase3promedio()
        {
            float suma = 0, promedio = 0;
            for (int j = 0; j < tiempoensablaje[2].Length; j++)
            {
                suma = suma + tiempoensablaje[2][j];
            }
            promedio = suma / tiempoensablaje[2].Length;

            return promedio;
        }
        public float tiempofase4promedio()
        {
            float suma = 0, promedio = 0;
            for (int j = 0; j < tiempoensablaje[3].Length; j++)
            {
                suma = suma + tiempoensablaje[3][j];
            }
            promedio = suma / tiempoensablaje[3].Length;

            return promedio;
        }
    }
    class PlantaIndustrial
    {
        private RobotEnsamblador[] robot;
        public PlantaIndustrial()
        {
            robot=new RobotEnsamblador[3];
            for(int i = 0;i < 3; i++)
            {
                robot[i] = new RobotEnsamblador();
            }
        }
        public void tiempo()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(robot[i].tiemposfase());
            }
        }
        public void timepoeficiente()
        {
            float min1 = robot[0].tiempofase1promedio(), min2 = robot[0].tiempofase2promedio(), min3 = robot[0].tiempofase3promedio(), min4 = robot[0].tiempofase4promedio();
            int indice = 0;
            for( int i = 0;i<3 ; i++)
            {
                if(min1> robot[i].tiempofase1promedio())
                {
                    min1 = robot[i].tiempofase1promedio();
                    indice = i;
                }
                if (i == 2)
                {
                    Console.WriteLine("el robot "+robot[indice].model()+" es el mas eficiente en la tarea 1");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (min2 > robot[i].tiempofase1promedio())
                {
                    min2 = robot[i].tiempofase1promedio();
                    indice = i;
                }
                if (i == 2)
                {
                    Console.WriteLine("el robot " + robot[indice].model() + " es el mas eficiente en la tarea 2");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (min3 > robot[i].tiempofase1promedio())
                {
                    min3 = robot[i].tiempofase1promedio();
                    indice = i;
                }
                if (i == 2)
                {
                    Console.WriteLine("el robot " + robot[indice].model() + " es el mas eficiente en la tarea 3");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (min4 > robot[i].tiempofase1promedio())
                {
                    min4 = robot[i].tiempofase1promedio();
                    indice = i;
                }
                if (i == 2)
                {
                    Console.WriteLine("el robot " + robot[indice].model() + " es el mas eficiente en la tarea 4");
                }
            }

        }
        static void Main(string[] args)
        {/*En una planta de fabricación automatizada, cada robot industrial realiza tareas de
        ensamblaje complejas divididas en operaciones secundarias de duración variable.
        ● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
        1. ModeloRobot.
        2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
        fila representa una de las 4 fases principales del proceso (Estructura,
        Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
        completar las distintas subtareas de esa fase (por ejemplo, en la fase de
        Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
        1).
        3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
        cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

        (definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
        una de ellas.

        ● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
        RobotEnsamblador. Implementar en PlantaIndustrial:
        1. Un constructor que cargue la información de los 3 robots instalados en la
        planta.
        2. Un método que muestre un reporte detallado con los tiempos de operación
        de cada robot fase por fase.
        3. Un método que calcule el promedio general de tiempo por tarea de cada
        robot y declare al Robot más Eficiente (aquel que registre el promedio de
        tiempo por operación más bajo de la planta).*/
            PlantaIndustrial p=new PlantaIndustrial();
            p.tiempo();
            p.timepoeficiente();
            Console.ReadKey();
        }
    }
}
