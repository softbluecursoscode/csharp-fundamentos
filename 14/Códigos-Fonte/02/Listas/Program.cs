using System;
using System.Collections.Generic;

namespace Listas
{
	class Program
	{
		static void Main()
		{
			List<string> nomes = new List<string>();
			nomes.Add("José");
			nomes.Add("Maria");
			nomes.Add("Pedro");
			nomes.Insert(1, "Paula");

			foreach (string nome in nomes)
			{
				Console.WriteLine(nome);
			}

			for (int i = 0; i < nomes.Count; i++)
			{
				string nome = nomes[i];
				Console.WriteLine(nome);
			}

			bool b = nomes.Contains("José");
			Console.WriteLine(b);

			int pos = nomes.IndexOf("Pedro");
			Console.WriteLine(pos);

			LinkedList<string> meses = new LinkedList<string>();
			meses.AddLast("Janeiro");
			meses.AddLast("Fevereiro");
			meses.AddLast("Março");

			foreach (string mes in meses)
			{
				Console.WriteLine(mes);
			}

			LinkedListNode<string> node = meses.First;
			Console.WriteLine(node.Value);

			while (node.Next != null)
			{
				node = node.Next;
				Console.WriteLine(node.Value);
			}
		}
	}
}
