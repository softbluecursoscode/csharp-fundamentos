using System;

namespace Exceptions
{
	class Program
	{
		static void Main()
		{
			try
			{
				object o = null;
				o.ToString();

				double r = Matematica.Dividir(10, 2);
				Console.WriteLine(r);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine("Ocorreu um erro: " + e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine("Referência null");
			}

			Console.WriteLine("Fim da aplicação");
		}
	}

	public class Matematica
	{
		public static double Dividir(double n, double d)
		{
			if (d == 0)
			{
				throw new ArgumentException("O denominador nao pode ser zero");
			}

			return n / d;
		}
	}
}
