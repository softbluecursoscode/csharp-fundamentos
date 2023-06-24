using System;

namespace Enumerations
{
	class Program
	{
		static void Main()
		{
			Elemento.Prioridade p1 = Elemento.Prioridade.Media;
			int i = (int)p1;
			Console.WriteLine(i);
			Console.WriteLine(p1.ToString());
		}
	}

	class Elemento
	{
		public enum Prioridade
		{
			Alta = 10,
			Media = 20,
			Baixa = 30
		}
	}
}
