using System;

namespace Arrays
{
	class Program
	{
		static void Main()
		{
			double[] notas = new double[3];
			notas[0] = 6.5;
			notas[1] = 9.0;
			notas[2] = 8.5;
			Console.WriteLine(notas[0]);
			Console.WriteLine(notas[1]);
			Console.WriteLine(notas[2]);

			//double[] notas = { 6.5, 9.0, 8.5 };

			Contato[] contatos = new Contato[10];
			Contato c1 = new Contato();
			c1.Nome = "José Silva";
			c1.Telefone = "5432-7789";
			contatos[0] = c1;

			char[,] tab = new char[3,8];
			tab[0, 0] = 'X';
			tab[2, 2] = 'O';
		}
	}

	public class Contato
	{
		public string Nome { get; set; }
		public string Telefone { get; set; }
	}
}
