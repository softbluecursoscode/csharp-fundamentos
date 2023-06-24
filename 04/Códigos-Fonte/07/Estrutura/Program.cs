using System;

namespace Estrutura
{
	class Program
	{
		static void Main()
		{
			Ponto p;
			p.x = 10;
			p.y = 20;

			p.MostrarCoordenadas();
		}
	}

	struct Ponto
	{
		public int x;
		public int y;

		public void MostrarCoordenadas()
		{
			Console.WriteLine("x = " + x + ", y = " + y);
		}
	}
}
