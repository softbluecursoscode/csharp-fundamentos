using System;

namespace Heranca
{
	class Program
	{
		static void Main()
		{
			Cachorro a = new Cachorro();
			a.Peso = 4;
			a.Altura = 0.8;
			//a.nome = "Rex";

			a.Mover();
			a.MostrarDados();
			a.Latir();
		}
	}
}
