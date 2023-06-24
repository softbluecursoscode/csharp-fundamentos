using System;
using System.Collections.Generic;

namespace Softblue
{
	class Program
	{
		static void Main(string[] args)
		{
			// Dicionários com as opções. Cada linguagem de programação possui um número único associado.
			Dictionary<int, string> opcoes = new Dictionary<int, string>();
			opcoes.Add(1, "C#");
			opcoes.Add(2, "Java");
			opcoes.Add(3, "C");
			opcoes.Add(4, "C++");
			opcoes.Add(5, "Python");

			// Lista que vai armazenar os votos dados.
			List<int> votos = new List<int>();

			int opcao;
			do
			{
				// Lê a opção votada.
				opcao = Votar(opcoes);
				Console.WriteLine("Obrigado pelo seu voto!\n");

				if (opcao > 0)
				{
					// Se for uma opção maior que zero, adiciona como voto (0 significa terminar a votação).
					votos.Add(opcao);
				}
			} while (opcao > 0);

			Console.WriteLine("{0,-25}{1,8}{2,10}", "Linguagem de Programação", "Votos", "%");
			Console.WriteLine("{0,-25}{1,8}{2,10}", "------------------------", "-----", "-");

			// Variáveis para armazenar o maior número de votos e a linguagem de programação associada.
			int maxVotos = -1;
			string maxLp = null;

			// Itera sobre as opções, para mostrar os resultados da votação.
			foreach (KeyValuePair<int, string> entry in opcoes)
			{
				int n = entry.Key;
				string lp = entry.Value;

				// Conta os votos de da opção.
				int numVotos = ContarVotos(n, votos);

				// Atualiza a opção com mais votos caso necessário.
				if (numVotos > maxVotos)
				{
					maxVotos = numVotos;
					maxLp = lp;
				}
				
				// Calcula a porcentagem, dividindo o número de votos pelo total de votos.
				double percent;
				if (votos.Count > 0)
				{
					percent = (double)numVotos / votos.Count;
				}
				else
				{
					// Se o total de votos for 0, considera 0% para evitar divisão por 0.
					percent = 0;
				}

				// Mostra as informações de votação da opção.
				Console.WriteLine("{0,-25}{1,8}{2,10:P1}", lp, numVotos, percent);
			}

			// Mostra o total de votos.
			Console.WriteLine("{0,-25}{1,8}", "------------------------", "-----");
			Console.WriteLine("{0,-25}{1,8}", "Total", votos.Count);

			// Mostra a opção mais votada.
			Console.WriteLine();
			Console.WriteLine("A opção '{0}' foi a mais votada, com {1} voto(s).", maxLp, maxVotos);
		}

		// Método que mostra as opções de votação e solicita um voto.
		static int Votar(Dictionary<int, string> opcoes)
		{
			while (true)
			{
				Console.WriteLine("Qual a sua linguagem de programação preferida?");

				// Imprime cada uma das opções, que estão armazenadas em um dicionário.
				foreach (KeyValuePair<int, string> entry in opcoes)
				{
					int n = entry.Key;
					string lp = entry.Value;
					Console.WriteLine("{0} - {1}", n, lp);
				}

				Console.Write("Escolha uma opção ou 0 para terminar => ");

				// Solicita um voto. Se o número não for válido, solicita novamente.
				int opcao;
				try
				{
					opcao = int.Parse(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.WriteLine("O número digitado é inválido\n");
					continue;
				}

				if (opcao < 0 || opcao > 5)
				{
					Console.WriteLine("Opção inválida\n");
					continue;
				}

				// Retorna o voto.
				return opcao;
			}
		}

		// Conta os votos de determinada opção. Recebe como parâmetro a opção e a lista de votos.
		static int ContarVotos(int n, List<int> votos)
		{
			// Contador de votos
			int numVotos = 0;

			// Itera sobre os votos, procurando votos da opção.
			foreach (int voto in votos)
			{
				if (voto == n)
				{
					numVotos++;
				}
			}
			
			// Retorna o número de votos.
			return numVotos;
		}
	}
}

