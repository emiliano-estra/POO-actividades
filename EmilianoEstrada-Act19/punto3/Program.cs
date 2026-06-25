using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Armar una clase parcial JuegoArcade.
        En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
        NivelDificultad (de 1 a 5). Valores cargados desde consola
        En el segundo archivo, implementar un método que indique si un puntaje ingresado
        supera el récord o no.
        Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.*/
            Juegoarcade i,j,k,l;
            i = new Juegoarcade();
            j = new Juegoarcade();
            k = new Juegoarcade();
            l = new Juegoarcade();
            i.Record(j.Puntajemaximo, k.Puntajemaximo, l.Puntajemaximo);
            j.Record(i.Puntajemaximo, k.Puntajemaximo, l.Puntajemaximo);
            k.Record(j.Puntajemaximo, i.Puntajemaximo, l.Puntajemaximo);
            l.Record(j.Puntajemaximo, k.Puntajemaximo, i.Puntajemaximo);
            Console.ReadKey();
        }
    }
}
