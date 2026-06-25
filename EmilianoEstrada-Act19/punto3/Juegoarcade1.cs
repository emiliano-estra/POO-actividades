using System;

partial class Juegoarcade
{
	protected string nombrejuego;
	protected int puntajemaximo, niveldificultad;
	public string Nombrejuego
	{
		set
		{
			nombrejuego = value;
		}
		get
		{
			return nombrejuego;
		}
	}
	public int Puntajemaximo
	{
		set
		{
			puntajemaximo = value;
		}
		get
		{
			return puntajemaximo;
		}
	}
	public int Niveldificultad
	{
		set
		{
			niveldificultad = value;
		}
		get
		{
			return niveldificultad;
		}
	}
	public Juegoarcade()
	{
        string linea;
        bool t = true;
        Console.WriteLine("ingrese el nombre del juego: ");
        Nombrejuego = Console.ReadLine();
        Console.WriteLine("ingrese el puntaje maximo: ");
		linea=Console.ReadLine();
        Puntajemaximo = int.Parse(linea);
        Console.WriteLine("ingrese el nivel de dificultad: ");
        linea = Console.ReadLine();
        if (int.Parse(linea) < 1 || int.Parse(linea)>5)
        {
            while (t)
            {
                Console.WriteLine("ingrese el nivel de dificultad (del 1 al 5): ");
                linea = Console.ReadLine();
                if (int.Parse(linea) > 1 || int.Parse(linea) < 5)
                {
                    Niveldificultad = int.Parse(linea);
                    t = false;
                }
            }
        }
        else
        {
            Niveldificultad = int.Parse(linea);
        }
    }
}
