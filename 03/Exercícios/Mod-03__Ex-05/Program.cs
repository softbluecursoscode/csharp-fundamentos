using System;

namespace Softblue
{
	class Program
	{
		// Imprime os 15 primeiros números da sequência de Fibonacci.
		static void Main()
		{
			int j = 1;

			// Este algoritmo é uma das maneiras de calcular a série de Fibonacci. As variáveis i e j
			// são utilizadas para percorrerem a sequência numérica e acumularem o resultado.
			for (int i = 0, cont = 0; cont < 15; cont++)
			{
				Console.WriteLine(i);
				i = i + j;
				j = i - j;
			}
		}
	}
}
