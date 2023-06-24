using System;

namespace Format
{
	class Program
	{
		static void Main()
		{
			string cidade = "Manaus";
			string estado = "Amazonas";

			Console.WriteLine("Cidade: " + cidade + ", Estado: " + estado);
			Console.WriteLine("Cidade: {0}, Estado: {1}", cidade, estado);

			Console.WriteLine("{0,-10}{1,-15}", "Cidade", "Estado");
			Console.WriteLine("{0,-10}{1,-15}", cidade, estado);

			Console.WriteLine("Valor: {0,10:C}", 2534.30);
			Console.WriteLine("Quantidade: {0,10:D5}", 35);
			Console.WriteLine("Peso: {0,10:N2}", 55.342);

			Console.WriteLine("{0:0000000000}", 345);
			Console.WriteLine("{0:\\(##\\) ####-####}", 1165437865);

			string s = string.Format("{0:\\(##\\) ####-####}", 1165437865);
			Console.WriteLine(s);
		}
	}
}
