using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Declara um objeto nulo
			object o = null;

			try
			{
				// Ao chamar este método o C# irá lançar uma NullReferenceException
				o.ToString();
			}
			catch (NullReferenceException e)
			{
				// Faz um catch da exceção e mostra uma mensagem amigável
				Console.WriteLine("O método está sendo chamado em um objeto nulo");
			}

			// Como a exceção foi tratada, o código continua normalmente, mostra a mensagem 
			// abaixo e termina
			Console.WriteLine("Fim do método");
		}
	}
}
