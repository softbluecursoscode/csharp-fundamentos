using System;

namespace Softblue
{
	/// <summary>
	/// Gerencia a palavra ativa do jogo.
	/// </summary>
	class Word
	{
		/// <summary>
		/// Caractere a ser mostrado no lugar das letras ainda não adivinhadas.
		/// </summary>
		private const char WildCard = '*';

		/// <summary>
		/// Objeto que gerencia as palavras do jogo.
		/// </summary>
		private Words words = new Words();

		/// <summary>
		/// Caracteres da palavra completa.
		/// </summary>
		private char[] completeWordChars;
		
		/// <summary>
		/// Caracteres da palavra parcial, que pode conter wildcards.
		/// </summary>
		private char[] partialWordChars;

		/// <summary>
		/// Palavra completa.
		/// </summary>
		public string CompleteWord { get; private set; }

		/// <summary>
		/// Palavra parcial.
		/// </summary>
		public string PartialWord
		{
			get
			{
				// Cria uma string usando o array de caracteres
				return new string(partialWordChars);
			}
		}

		/// <summary>
		/// Indica se o jogo terminou (i.e. a palavra foi adivinhada por completo).
		/// </summary>
		public bool Finished
		{
			get
			{
				// Verifica se a palava parcial é igual à palavra completa.
				return PartialWord == CompleteWord;
			}
		}

		/// <summary>
		/// Construtor
		/// </summary>
		public Word()
		{
			// Ao ser construído, o objeto já busca a primeira palavra.
			Next();
		}

		/// <summary>
		/// Obtém uma nova palavra.
		/// </summary>
		public void Next()
		{
			// Sorteia uma nova palavra.
			this.CompleteWord = words.Pick();
			
			// Converte a palavra para um char[]
			this.completeWordChars = this.CompleteWord.ToCharArray();

			// Instancia o array de caracteres da palavra parcial, e atribui o wildcard a todas as posições.
			this.partialWordChars = new char[completeWordChars.Length];
			for (int i = 0; i < partialWordChars.Length; i++)
			{
				if (completeWordChars[i] != ' ')
				{
					partialWordChars[i] = WildCard;
				}
				else
				{
					partialWordChars[i] = ' ';
				}
			}
		}

		/// <summary>
		/// Tenta adivinhar uma letra.
		/// </summary>
		/// <param name="letter">Letra a ser adivinhada.</param>
		/// <returns>True se a letra existir na palavra; false caso contrário.</returns>
		public bool Guess(char letter)
		{
			bool found = false;

			// Converte o caractere para maiúsculo, pois as palavras estão todas com letras maiúsculas.
			letter = Char.ToUpper(letter);

			// Procura a letra na palavra.
			for (int i = 0; i < completeWordChars.Length; i++)
			{
				if (completeWordChars[i] == letter)
				{
					// Se a letra for encontrada, o array de caracteres da palavra parcial tem o wildcard 
					// correspondente substituído pela letra.
					partialWordChars[i] = letter;
					found = true;
				}
			}

			return found;
		}
	}
}
