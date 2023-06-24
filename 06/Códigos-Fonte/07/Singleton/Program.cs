using System;

namespace Singleton
{
	class Program
	{
		static void Main()
		{
			Gerenciador g1 = Gerenciador.Instance;
			Gerenciador g2 = Gerenciador.Instance;
			Gerenciador g3 = Gerenciador.Instance;
		}
	}
}
