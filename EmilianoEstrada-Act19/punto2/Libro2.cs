using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace punto2
{
partial class Libro
{
	public void Resumen()
	{
		Console.WriteLine("el libro es "+Titulo+"\n el autor es "+Autor);
			if (Paginas >= 100)
			{
				Console.Write("es un libro largo");
			}
			else
			{
				Console.Write("es un libro corto");
			}
	}
}
}
