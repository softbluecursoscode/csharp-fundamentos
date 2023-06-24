using System;

namespace ArrayIterator
{
	class Program
	{
		static void Main()
		{
			char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

			for (int i = 0; i < alfabeto.Length; i++)
			{
				char letra = alfabeto[i];
				Console.WriteLine(letra);
			}

			foreach (char letra in alfabeto)
			{
				Console.WriteLine(letra);
			}

			int[,] matriz = {
 								{ 3, 7, 8, 2, 0 },
								{ 5, 6, 1, 4, 9 }
							};

			foreach (int n in matriz)
			{
				Console.WriteLine(n);
			}

			for (int i = 0; i < matriz.GetLength(0); i++)
			{
				for (int j = 0; j < matriz.GetLength(1); j++)
				{
					int n = matriz[i, j];
					Console.WriteLine(n);
				}
			}
		}
	}
}
