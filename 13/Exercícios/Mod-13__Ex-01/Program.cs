using System;
using System.Collections.Generic;

namespace Softblue
{
	class Program
	{
		static void Main(string[] args)
		{
			// Cria o array com 5 posições.
			int[] array = new int[5];

			// Itera sobre o array, lendo o dado a ser armazenado em cada posição a partir do console.
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("Digite o elemento {0}: ", i + 1);
				
				// É preciso converter de string para int.
				int n = int.Parse(Console.ReadLine());
				
				array[i] = n;
			}

			// Variável que vai acumular a soma dos elementos (para posterior cálculo da média).
			int soma = 0;
			
			// Variável para armazenar o menor valor. O valor inicial é o maior int possível, para que qualquer outro número
			// seja menor.
			int menor = int.MaxValue;

			// Variável para armazenar o maior valor. O valor inicial é o menor int possível, para que qualquer outro número
			// seja maior.
			int maior = int.MinValue;
			
			// Itera sobre o array para fazer a soma e achar os números maior e menor.
			foreach (int n in array)
			{
				soma += n;

				// Os métodos Min e Max de Math retornam o menor e maior valor entre os valores fornecidos, respectivamente.
				menor = Math.Min(menor, n);
				maior = Math.Max(maior, n);
			}

			// Calcula a média. soma é convertido para double para que o resultado seja um double, e não um int.
			double media = (double)soma / array.Length;

			// Escreve a média e os números maior e menor.
			Console.WriteLine("Média: {0}\nMaior: {1}\nMenor: {2}", media, maior, menor);

			// Ordena os elementos do array de acordo com o critério estabelecido em ArrayComparer (ordem decrescente).
			Array.Sort(array, new ArrayComparer());

			// Imprime os elementos após a ordenação.
			Console.Write("Array ordenado: ");
			foreach (int n in array)
			{
				Console.Write("{0} ", n);
			}
			Console.WriteLine();
		}
	}

	// Classe que implementa o crítério de ordenação.
	class ArrayComparer : IComparer<int>
	{
		public int Compare(int x, int y)
		{
			// Usa o CompareTo() já existente no int. Como este método faz a ordenação em ordem crescente, a inversão do sinal 
			// faz com que a ordenação seja feita em ordem decrescente.
			return -x.CompareTo(y);
		}
	}
}
