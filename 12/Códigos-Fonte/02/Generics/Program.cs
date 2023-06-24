using System;

namespace Generics
{
	class Program
	{
		static void Main()
		{
			Lista<int> l = new Lista<int>();

			l.Adicionar(10);
			l.Adicionar(20);
			l.Adicionar(30);

			int e1 = l.Ler(0);
			int e2 = l.Ler(1);
			int e3 = l.Ler(2);

			Console.WriteLine("{0}, {1}, {2}", e1, e2, e3);
		}
	}
}
