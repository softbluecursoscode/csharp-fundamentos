using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Solicita o número
			Console.Write("Digite um número: ");
			int x = int.Parse(Console.ReadLine());

			// Guarda o valor original digitado para usar mais tarde
			int valor = x;

			// Repete enquanto x for menor do que 1000
			while (x < 1000)
			{
				if (x % 2 == 0)
				{
					// x é par (o resto da divisão por 2 é 0).
					x = x + 5;

				}
				else
				{
					// x é ímpar.
					x = x * 2;
				}

				Console.WriteLine(x);
			}

			// Restaura o valor digitado pelo usuário
			x = valor;

			// A mesma lógica, mas usando switch.
			while (x < 1000)
			{
				switch (x % 2)
				{
					case 0:
						x = x + 5;
						break;
					default:
						x = x * 2;
						break;
				}

				Console.WriteLine(x);
			}
		}
	}
}
