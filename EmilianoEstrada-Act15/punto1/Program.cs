using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    internal class pacientes
    {
        private string nombre;
        private int[,] ritmocardiaco;
        public pacientes(){
            ritmocardiaco=new int[3,4];
            Console.WriteLine("ingrese el nombre del paciente. ");
            nombre=Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++) {
                    Console.WriteLine("ingrese el ritmo cardiaco del dia "+i+" : ");
                    ritmocardiaco[i,j]=int.Parse(Console.ReadLine());
                }
            }
        }
        public string ritmo()
        {
            string grilla="";
            for (int i = 0; i < 3; i++) {
                if (i == 0)
                {
                    grilla += "      mañana mediodia tarde noche \n";
                }
                for (int j = 0; j < 4; j++) {
                    
                    if (j == 0){
                        grilla += "dia" + i+" : ";
                    }
                    grilla += ritmocardiaco[i, j]+" ";
                    if (j == 3)
                    {
                        grilla+="\n";
                    }
                } 
            }
            return grilla;
        }
        public double promediopul()
        {
            double suma = 0,promedio=0;
            for (int i = 0; i < ritmocardiaco.GetLength(0); i++)
            {
                for(int j = 0; j < ritmocardiaco.GetLength(1); j++)
                {
                    suma = suma + ritmocardiaco[i, j];
                }
            }
            promedio = suma / 12;
            return promedio;
        }
        public string nombrepa() {
            return nombre;
        }
        public bool taquicardia()
        {
            for (int i = 0;i<ritmocardiaco.GetLength(0); i++)
            {
                for( int j = 0;j<ritmocardiaco.GetLength (1); j++)
                {
                    if(ritmocardiaco [i,j] > 120)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public string pulsaciones()
        {
            string pulsacionmayor = "";
            for (int i = 0; i < ritmocardiaco.GetLength(0); i++)
            {
                for (int j = 0; j < ritmocardiaco.GetLength(1); j++)
                {
                    if (ritmocardiaco[i, j] > 120)
                    {
                        pulsacionmayor += ritmocardiaco[i, j]+" ";
                    }
                }
            }
            return pulsacionmayor;
        }
    }
    class salamonitoreo{
        private pacientes[] ingresado;
        public salamonitoreo() {
            ingresado = new pacientes[3];
            for (int i = 0; i < 3; i++) {
                ingresado[i] = new pacientes();
            }
        }
        public void grilla()
        {
            string grillatotal="";
            for (int i = 0; i < 3; i++)
            {
                grillatotal+=ingresado[i].ritmo()+"\n";
            }
            Console.WriteLine(grillatotal);
        }
        public void promedio()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("el paciente "+ingresado[i].nombrepa()+" con un promedio de "+ ingresado[i].promediopul());
            }
        }
        public void posibletaquicardia()
        {
            for (int i = 0; i < 3; i++) {
               if(ingresado[i].taquicardia())
                {
                    Console.WriteLine("el paciente " + ingresado[i].nombrepa()+" tuvo una taquicardia severa con pulsaciones de " + ingresado[i].pulsaciones());
                }
            }
        }
        static void Main(string[] args)
        {/*En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
        cardíaco de los pacientes.
        ● Plantear una clase llamada Paciente que tenga como atributos privados:
        1. Nombre (de tipo string).
        2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
        registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
        clave de cada día: mañana, mediodía, tarde y noche).
        3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
        teclado de las 12 lecturas cardíacas.

        ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
        objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
        carga de los 3 pacientes. Implementar los siguientes métodos dentro de
        SalaMonitoreo:
        1. Un método que imprima la grilla de lecturas cardíacas completa de cada
        paciente organizada por día y momento.
        2. Un método que calcule e imprima el promedio de pulsaciones de cada
        paciente a lo largo de todo su monitoreo.
        3. Un método que verifique si algún paciente registró un evento de taquicardia
        severa (cualquier lectura individual que sea estrictamente mayor a 120
        pulsaciones), mostrando por consola su nombre y la lectura detectada.*/
            salamonitoreo sal=new salamonitoreo();
            sal.grilla();
            sal.promedio();
            sal.posibletaquicardia();
            Console.ReadKey();
        }
    }
}
