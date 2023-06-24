using System;
using System.Collections.Generic;
using System.IO;

namespace Softblue
{
	class Program
	{
		// Constante para o arquivo da lista
		private const string ListFile = "lista.txt";

		static void Main()
		{
			// Lê os registros já cadastrados na lista (caso existam)
			string[] lista = ReadFile();

			// Se a variável lista tiver itens, significa que itens já haviam sido cadastrados
			if (lista != null && lista.Length > 0)
			{
				Console.WriteLine("Estes são os itens já cadastrados: ");

				// Itera sobre os registros cadastrados e mostra na tela
				foreach (String item in lista)
				{
					Console.WriteLine("=> " + item);
				}
			}


			// Abre uma stream para o arquivo de saída
			FileStream fs = new FileStream(ListFile, FileMode.Append, FileAccess.Write);
			using (StreamWriter writer = new StreamWriter(fs))
			{
				// Loop
				while (true)
				{
					// Solicita um novo item pelo teclado
					Console.Write("Digite um item: ");
					String item = Console.ReadLine();

					// Se um item vazio foi inserido, volta para o início do loop (desconsidera o que foi digitado)
					if (String.IsNullOrWhiteSpace(item))
					{
						continue;
					}

					// Se o item digitado foi 0, termina o programa (sai do loop)
					if (item == "0")
					{
						Console.WriteLine("Fim da execução");
						break;
					}

					// Grava o item digitado no arquivo de saída, com uma quebra de linha no fim
					writer.WriteLine(item);
				}
			}
		}

		// Este método lê os itens cadastrados no arquivo para uma lista
		private static string[] ReadFile()
		{
			// Verifica se o arquivo existe. Se não existe, retorna null
			if (!File.Exists(ListFile))
			{
				return null;
			}

			// Lê os itens para um array de strings
			string[] lista = File.ReadAllLines(ListFile);

			return lista;
		}
	}
}