using System;

namespace Static
{
	class Program
	{
		static void Main()
		{
			Bola b1 = new Bola();
			Bola b2 = new Bola();
			Bola b3 = new Bola();
			Console.WriteLine(Bola.numBolas);

			int r = Matematica.Somar(20, 3);
			Console.WriteLine(r);
		}
	}

	class Bola
	{
		public static int numBolas;

		public Bola()
		{
			numBolas++;
		}
	}

	class Matematica
	{
		public static int Somar(int a, int b)
		{
			return a + b;
		}
	}
}
