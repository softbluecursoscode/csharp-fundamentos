using System;

namespace Sobrecarga
{
	class Program
	{
		static void Main()
		{
			Matematica m = new Matematica();

			int r1 = m.Somar(10, 5);
			Console.WriteLine(r1);

			double r2 = m.Somar(5.5, 8);
			Console.WriteLine(r2);

			int r3 = m.Somar(10, 5, 6);
			Console.WriteLine(r3);
		}
	}

	class Matematica
	{
		public int Somar(int a, int b)
		{
			Console.WriteLine("[int, int]");
			return a + b;
		}

		public int Somar(int a, int b, int c)
		{
			Console.WriteLine("[int, int, int]");
			return a + b + c;
		}

		public double Somar(double a, double b)
		{
			Console.WriteLine("[double, double]");
			return a + b;
		}

		public long Somar(long a, long b)
		{
			Console.WriteLine("[long, long]");
			return a + b;
		}
	}
}
