using System;

namespace Singleton
{
	class Gerenciador
	{
		private static readonly Gerenciador instance = new Gerenciador();

		public static Gerenciador Instance
		{
			get
			{
				return instance;
			}
		}

		private Gerenciador()
		{
		}

		public void Gerenciar()
		{
		}
	}
}
