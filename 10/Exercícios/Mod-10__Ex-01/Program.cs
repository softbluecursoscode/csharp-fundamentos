using System;
using System.Text;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(Processar(null));
			Console.WriteLine(Processar("ab"));
			Console.WriteLine(Processar("abcdefg"));
		}

		private static String Processar(string s)
		{
			if (s == null)
			{
				// Se a string é nula, retorna null
				return null;
			}

			// Converte a string para maiúscula
			s = s.ToUpper();

			if (s.Length <= 3)
			{
				// Se o tamanho for menor ou igual a 3, retorna a string em maiúscula
				return s;
			}

			// Se o tamanho for maior que 3, substitui os 3 primeiros caracteres por '???'
			s = "???" + s.Substring(3);

			return s;
		}
	}
}
