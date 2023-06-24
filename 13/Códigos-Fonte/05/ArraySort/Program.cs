using System;
using System.Collections.Generic;

namespace ArraySort
{
	class Program
	{
		static void Main()
		{
			string[] frutas = { "Limão", "Mamão", "Laranja", "Açaí", "Abacaxi", "Cajá" };

			Array.Sort(frutas);

			foreach (string fruta in frutas)
			{
				Console.WriteLine(fruta);
			}

			Atleta[] atletas = new Atleta[6];
			atletas[0] = new Atleta { Nome = "Paulo", Tempo = 60 };
			atletas[1] = new Atleta { Nome = "Pedro", Tempo = 58 };
			atletas[2] = new Atleta { Nome = "Maria", Tempo = 63 };
			atletas[3] = new Atleta { Nome = "Alice", Tempo = 65 };
			atletas[4] = new Atleta { Nome = "João", Tempo = 58 };
			atletas[5] = new Atleta { Nome = "Julia", Tempo = 57 };

			Array.Sort(atletas);

			foreach (Atleta atleta in atletas)
			{
				Console.WriteLine(atleta);
			}

			int[] numeros = { 5, 6, 2, 0, 4, 7, 6 };

			ComparadorDecrescente c = new ComparadorDecrescente();

			Array.Sort(numeros, c);

			foreach (int numero in numeros)
			{
				Console.WriteLine(numero);
			}
		}
	}

	public class ComparadorDecrescente : IComparer<int>
	{
		public int Compare(int x, int y)
		{
			if (x == y)
			{
				return 0;
			}

			if (x > y)
			{
				return -1;
			}

			return 1;
		}
	}

	public class Atleta : IComparable<Atleta>
	{
		public string Nome { get; set; }
		public int Tempo { get; set; }

		public override string ToString()
		{
			return string.Format("{0,-7} => {1}", Nome, Tempo);
		}

		public int CompareTo(Atleta other)
		{
			if (this.Tempo == other.Tempo)
			{
				return 0;
			}

			if (this.Tempo > other.Tempo)
			{
				return 1;
			}

			return -1;
		}
	}
}
