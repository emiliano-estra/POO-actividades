using System;

partial class Juegoarcade
{
    public void Record(int puntaje1,int puntaje2,int puntaje3)
    {
        if (Puntajemaximo>puntaje1 &&Puntajemaximo>puntaje2&& Puntajemaximo>puntaje3)
        {
            Console.WriteLine("el jugador "+Nombrejuego+" rompio el record con "+Puntajemaximo);
        }
    }
}
