using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Lê o número de linhas da matriz.
			Console.Write("Número de linhas: ");
			int rows = ReadInt();
			
			// Lê o número de colunas da matriz.
			Console.Write("Número de colunas: ");
			int cols = ReadInt();

			// Cria a matriz.
			int[,] matrix = new int[rows, cols];

			Console.WriteLine();

			// Lê cada um dos elementos da matriz.
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write("Valor para o elemento [{0},{1}]: ", i, j);
					matrix[i, j] = ReadInt();
				}
			}

			Console.WriteLine();
			
			// Imprime a matriz.
			Imprimir(matrix);

			// Cria um array para as somas de valores das colunas. O tamanho do array deve ser igual
			// ao tamanho de colunas da matriz.
			int[] somas = new int[cols];

			// Itera sobre o array de somas, fazendo o cálculo.
			for (int i = 0; i < somas.Length; i++)
			{
				// A variável soma acumula a soma das linhas.
				int soma = 0;

				// Itera sobre as linhas da coluna.
				for (int j = 0; j < matrix.GetLength(0); j++)
				{
					// Vai somando os valores das linhas.
					soma += matrix[j, i];
				}

				// No final, armazena a soma no array de somas.
				somas[i] = soma;
			}

			Console.WriteLine();
			
			// Imprime as somas.
			Imprimir(somas);
		}

		// Método que itera sobre os elementos da matriz e imprime cada um deles.
		static void Imprimir(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write("{0,-5}", matrix[i, j]);
				}
				Console.WriteLine();
			}
		}

		// Método que itera sobre os elementos do array e imprime cada um deles.
		static void Imprimir(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("{0,-5}", array[i]);
			}
			Console.WriteLine();
		}

		// Método auxiliar para ler um int a partir do console.
		static int ReadInt()
		{
			return int.Parse(Console.ReadLine());
		}
	}
}
