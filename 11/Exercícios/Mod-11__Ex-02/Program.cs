using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Simulador de Mega-Sena");
			Console.WriteLine("----------------------");

			// Solicita os números.
			// Este algoritmo não faz validação de intervalos de números ou se os números digitados são válidos.
			Console.Write("Palpite 1: ");
			int n1 = int.Parse(Console.ReadLine());
			Console.Write("Palpite 2: ");
			int n2 = int.Parse(Console.ReadLine());
			Console.Write("Palpite 3: ");
			int n3 = int.Parse(Console.ReadLine());
			Console.Write("Palpite 4: ");
			int n4 = int.Parse(Console.ReadLine());
			Console.Write("Palpite 5: ");
			int n5 = int.Parse(Console.ReadLine());
			Console.Write("Palpite 6: ");
			int n6 = int.Parse(Console.ReadLine());

			Console.WriteLine();

			// Cria um gerador de números randômicos.
			Random random = new Random();

			// Sorteia 6 números. O método Next() é chamado com 1,61 para gerar números entre 1 e 60.
			int s1 = random.Next(1, 61);
			int s2 = random.Next(1, 61);
			int s3 = random.Next(1, 61);
			int s4 = random.Next(1, 61);
			int s5 = random.Next(1, 61);
			int s6 = random.Next(1, 61);

			// Mostra os números sorteados.
			Console.WriteLine("Números sorteados: {0}, {1}, {2}, {3}, {4}, {5}", s1, s2, s3, s4, s5, s6);

			// Variável para computar os acertos.
			int acertos = 0;

			// Processa os acertos, comparando cada número sorteado com cada palpite do usuário.
			if (s1 == n1 || s1 == n2 || s1 == n3 || s1 == n4 || s1 == n5 || s1 == n6)
			{
				acertos++;
			}

			if (s2 == n1 || s2 == n2 || s2 == n3 || s2 == n4 || s2 == n5 || s2 == n6)
			{
				acertos++;
			}

			if (s3 == n1 || s3 == n2 || s3 == n3 || s3 == n4 || s3 == n5 || s3 == n6)
			{
				acertos++;
			}

			if (s4 == n1 || s4 == n2 || s4 == n3 || s4 == n4 || s4 == n5 || s4 == n6)
			{
				acertos++;
			}

			if (s5 == n1 || s5 == n2 || s5 == n3 || s5 == n4 || s5 == n5 || s5 == n6)
			{
				acertos++;
			}

			if (s6 == n1 || s6 == n2 || s6 == n3 || s6 == n4 || s6 == n5 || s6 == n6)
			{
				acertos++;
			}

			// Mostra o número de acertos.
			Console.WriteLine("Você acertou {0} número(s)!", acertos);
		}
	}
}
