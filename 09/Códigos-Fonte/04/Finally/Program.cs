using System;

namespace Finally
{
	class Program
	{
		static void Main()
		{
			try
			{
				Executar(false);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine("Exceção tratada");
			}
			finally
			{
				Console.WriteLine("Aplicação terminada");
			}
		}

		static void Executar(bool b)
		{
			if (b)
			{
				throw new ArgumentException();
			}
		}
	}
}
