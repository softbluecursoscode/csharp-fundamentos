using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria um triângulo e define seus pontos.
			Triangulo<int> t1 = new Triangulo<int>();
			t1.DefinirPontos(0, 0, 0, 0, 3, 5, 2, 2, 4);
			Console.WriteLine(t1);

			// Cria outro triângulo com os mesmos pontos de T1.
			Triangulo<int> t2 = new Triangulo<int>(t1.P1, t1.P2, t1.P3);
			Console.WriteLine(t2);
		}
	}
}
