using System;

namespace MainParam
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length != 2)
			{
				Console.WriteLine("O número de parâmetros é inválido");
				return;
			}


			int a = int.Parse(args[0]);
			int b = int.Parse(args[1]);

			Console.WriteLine("A soma é " + (a + b));
		}
	}
}
