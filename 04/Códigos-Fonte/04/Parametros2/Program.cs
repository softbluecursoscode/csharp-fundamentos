using System;

namespace Parametros2
{
	class Program
	{
		static void Main()
		{
			Matematica m = new Matematica();

			int a = 10;
			int b = 2;
			int result;
			m.Multiplicar(a, b, out result);
			Console.WriteLine(result);

			int r1;
			int r2;
			m.MultiplicarESomar(3, 6, out r1, out r2);
			Console.WriteLine(r1);
			Console.WriteLine(r2);

			double pot = m.Elevar(2);
			Console.WriteLine(pot);
		}
	}

	class Matematica
	{
		public void Multiplicar(int a, int b, out int c)
		{
			c = a * b;
		}

		public void MultiplicarESomar(int a, int b, out int rm, out int rs)
		{
			rm = a * b;
			rs = a + b;
		}

		public double Elevar(double n, double pot = 2)
		{
			return Math.Pow(n, pot);
		}
	}
}
