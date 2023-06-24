using System;
using System.Collections.Generic;

namespace Dicionarios
{
	class Program
	{
		static void Main()
		{
			Estado e1 = new Estado("Rio Grande do Sul");
			Estado e2 = new Estado("Santa Catarina");
			Estado e3 = new Estado("Paraná");

			Dictionary<string, Estado> dic = new Dictionary<string, Estado>();
			dic.Add("RS", e1);
			dic.Add("SC", e2);
			dic.Add("PR", e3);

			dic["RS"] = e1;
			dic["SC"] = e2;
			dic["PR"] = e3;

			try
			{
				Estado e = dic["PR"];
				Console.WriteLine(e.Nome);
			}
			catch (KeyNotFoundException e)
			{
				Console.WriteLine("A chave não existe");
			}

			Estado ePR;
			bool exist = dic.TryGetValue("PR", out ePR);
			Console.WriteLine(exist);

			Dictionary<string, Estado>.KeyCollection keys = dic.Keys;
			foreach (string key in keys)
			{
				Console.WriteLine(key);
			}

			Dictionary<string, Estado>.ValueCollection values = dic.Values;
			foreach (Estado estado in values)
			{
				Console.WriteLine(estado.Nome);
			}

			foreach (KeyValuePair<string, Estado> entry in dic)
			{
				string key = entry.Key;
				Estado value = entry.Value;

				Console.WriteLine(key + " => " + value.Nome);
			}
		}
	}

	public class Estado
	{
		public string Nome { get; set; }

		public Estado(string nome)
		{
			this.Nome = nome;
		}
	}
}
