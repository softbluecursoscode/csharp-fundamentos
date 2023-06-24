using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Tarefa 1.
			// Imprime os números compreendidos entre 10 e 25.
			for (int i = 10; i <= 25; i++)
			{
				Console.WriteLine(i);
			}

			// Tarefa 2.
			// Imprime a soma de 1 a 100, pulando de 2 em 2.
			// Para "pular", basta incrementar i em 2 unidades, ao invés de 1. A variável soma armazena a soma.
			int soma = 0;
			for (int i = 1; i <= 100; i += 2)
			{
				soma += i;
			}
			Console.WriteLine(soma);

			// Tarefa 3.
			// Imprime os números começando 0, até que a soma dos números impressos seja menor que 100.
			// A variável i controla o número atual, enquanto soma armazena a soma dos números.
			// No momento em que a soma for maior ou igual a 100, o loop termina
			int n = 0;
			soma = 0;
			while (soma < 100)
			{
				Console.WriteLine(n);
				soma += n;
				n++;
			}

			// Tarefa 4.
			// Imprime a tabuada do 9
			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine("9 x " + i + " = " + 9 * i);
			}
		}
	}
}
