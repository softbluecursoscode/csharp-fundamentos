using System;

namespace EstruturasControle
{
	class Program
	{
		static void Main()
		{
			// Estrutura if-else (1)
			{
				int x = 20;

				if (x > 5)
				{
					Console.WriteLine("Número maior que 5");
				}
				else
				{
					Console.WriteLine("Número não é maior que 5");
				}

				Console.WriteLine("Fim do programa");
			}

			// Estrutura if-else (2)
			{
				int x = 0;

				if (x > 0)
				{
					Console.WriteLine("Número Positivo");
				}
				else if (x < 0)
				{
					Console.WriteLine("Número negativo");
				}
				else
				{
					Console.WriteLine("Número zero");
				}

				Console.WriteLine("Fim do programa");
			}

			// Estrutura switch
			{
				int mes = 5;

				switch (mes)
				{
					case 1:
					case 3:
					case 5:
					case 7:
					case 8:
					case 10:
					case 12:
						Console.WriteLine("31 dias");
						break;
					case 2:
						Console.WriteLine("28 dias");
						break;
					case 4:
					case 6:
					case 9:
					case 11:
						Console.WriteLine("30 dias");
						break;
					default:
						Console.WriteLine("Mês inválido");
						break;
				}
			}
		}
	}
}
