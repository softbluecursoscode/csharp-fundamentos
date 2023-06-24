using System;
using System.IO;

namespace Softblue
{
	/// <summary>
	/// Gerencia as palavras que fazem parte do jogo.
	/// </summary>
	class Words
	{
		/// <summary>
		/// Nome do arquivo onde estão as palavras. As palavras devem estar uma em cada linha.
		/// </summary>
		private const string FileName = "words.txt";
		
		/// <summary>
		/// Gerador de números randômicos.
		/// </summary>
		private Random random = new Random();

		/// <summary>
		/// Array com as palavras que fazem parte do jogo.
		/// </summary>
		private string[] words;

		/// <summary>
		/// Construtor.
		/// </summary>
		public Words()
		{
			// Lê as palavras.
			ReadWords();
		}

		/// <summary>
		/// Lê as palavras do arquivo.
		/// </summary>
		private void ReadWords()
		{
			// Lê as palavras para dentro do array.
			this.words = File.ReadAllLines(FileName);

			// Converte todas as letras das palavras para maiúsculas.
			for (int i = 0; i < words.Length; i++)
			{
				words[i] = words[i].ToUpper();
			}
		}

		/// <summary>
		/// Sorteia uma nova palavra.
		/// </summary>
		/// <returns>Retorna a palavra sorteada.</returns>
		public string Pick()
		{
			// Gera um número entre 0 e o tamanho do array de palavras
			int index = random.Next(words.Length);
			
			return words[index];
		}
	}
}
