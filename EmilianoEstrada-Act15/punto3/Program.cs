using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class ReservaNatural
    {
        private string nombre;
        private int[,] avistamientos;
        public ReservaNatural()
        {
            avistamientos = new int[3, 3];
            string linea;
            Console.WriteLine("ingrese el nombre de la reserva: ");
            nombre = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("ingrese la cantidad de animales vistados en el sector" + i + " " + j + ": ");
                    linea = Console.ReadLine();
                    avistamientos[i, j] = int.Parse(linea);
                }
            }
        }
        public string nom()
        {
            return nombre;
        }
        public int avistamientostotal()
        {
            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma = suma+avistamientos[i, j];
                }
            }
            return suma;
        }
        public int avistamientomax()
        {
            int avi = avistamientos[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (avi < avistamientos[i, j])
                    {
                        avi = avistamientos[i, j];
                    }
                }
            }
            return avi;
        }
        public string cordenada()
        {
            int avi = avistamientos[0, 0];
            string cordenada = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (avi < avistamientos[i, j])
                    {
                        avi = avistamientos[i, j];
                        cordenada = " "+i +""+j;
                    }
                }
            }
            return cordenada;
        }
        class CentroEcologico
        {
            private ReservaNatural[] reserva;
            public CentroEcologico()
            {
                reserva = new ReservaNatural[3];
                for (int i = 0; i < 3; i++)
                {
                    reserva[i] = new ReservaNatural();
                }

            }
            public void totalavistamentos()
            {
                for (int i = 0; i < 3; i++)
                {
                    reserva[i].avistamientostotal();
                    Console.WriteLine("en la reserva " + reserva[i].nom() + " tiene en total de avistamientos de " + reserva[i].avistamientostotal());
                }
            }
            public void mayoravistamiento()
            {
                if ((reserva[0].avistamientomax() > reserva[1].avistamientomax()) && (reserva[0].avistamientomax() > reserva[2].avistamientomax()))
                {
                    Console.WriteLine("la reserva " + reserva[0].nom() + " tiene el mayor avistamiento en la corenada" + reserva[0].cordenada());
                }
                if ((reserva[1].avistamientomax() > reserva[0].avistamientomax()) && (reserva[1].avistamientomax() > reserva[2].avistamientomax()))
                {
                    Console.WriteLine("la reserva " + reserva[1].nom() + " tiene el mayor avistamiento en la corenada" + reserva[1].cordenada());
                }
                else
                {
                    Console.WriteLine("la reserva " + reserva[2].nom() + " tiene el mayor avistamiento en la corenada" + reserva[2].cordenada());
                }

            }
            static void Main(string[] args)
            {/*Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
        especies protegidas en cuadrículas de territorio.
        ● Confeccionar la clase ReservaNatural que tenga como atributos privados el
        NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
        mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
        cantidad de animales avistados en cada sector). El constructor de la clase debe
        cargar por teclado el nombre y rellenar el mapa de avistamientos.
        ● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
        objetos de la clase ReservaNatural.
        La clase CentroEcologico debe implementar los siguientes métodos:
        1. Un constructor que solicite la carga secuencial de las 3 reservas.
        2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
        registró en toda su superficie (la suma de toda su matriz rectangular).
        3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
        columna]) que registró la mayor concentración de avistamientos de toda la red de
        reservas, indicando a qué reserva pertenece.*/
                CentroEcologico c=new CentroEcologico();
                c.totalavistamentos();
                c.mayoravistamiento();
                Console.ReadKey();
            }
        }
    }
}
