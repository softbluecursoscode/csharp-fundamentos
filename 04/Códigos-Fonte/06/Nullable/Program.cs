using System;

namespace Nullable
{
	class Program
	{
		static void Main()
		{
			int? n = null;

			if (n == null)
			{
				Console.WriteLine("Valor nulo");
			}

			if (!n.HasValue)
			{
				Console.WriteLine("Valor nulo");
			}

			int x = n ?? 0;

			Console.WriteLine(x);
		}
	}
}
