using System;

namespace PolimorfismoInterface
{
	class Program
	{
		static void Main()
		{
			Selo s = new Selo();
			ImprimirColecao(s);

			Bone b = new Bone();
			ImprimirColecao(b);
		}

		static void ImprimirColecao(IColecionavel c)
		{
			Console.WriteLine("Esta é uma coleção de " + c.GetNomeColecao());
		}
	}

	public interface IColecionavel
	{
		string GetNomeColecao();
	}

	public class Selo : IColecionavel
	{
		public string GetNomeColecao()
		{
			return "selos";
		}
	}

	public class Bone : IColecionavel
	{
		public string GetNomeColecao()
		{
			return "bonés";
		}
	}
}
