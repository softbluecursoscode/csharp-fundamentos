using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cadastro dos produtos
			Produto p1 = new Produto("Feijão", 2.5, 4, 10, 2020);
			Produto p2 = new Produto("Café", 1, 1, 1, 2022);
			Produto p3 = new Produto("Beterraba", 0.9, 12, 11, 2017);

			// Exibição dos dados formatados
			Console.WriteLine("{0}) {1,12} {2:000000.00} {3}", 1, p1.Nome, p1.Peso, p1.FormattedDataValidade);
			Console.WriteLine("{0}) {1,12} {2:000000.00} {3}", 2, p2.Nome, p2.Peso, p2.FormattedDataValidade);
			Console.WriteLine("{0}) {1,12} {2:000000.00} {3}", 3, p3.Nome, p3.Peso, p3.FormattedDataValidade);
		}
	}

	class Produto
	{
		// Nome do produto
		private string nome;

		// Peso do produto
		private double peso;

		// Data de validade
		private DateTime dataValidade;

		// Construtor. Recebe nome, peso e data de validade
		public Produto(string nome, double peso, int dia, int mes, int ano)
		{
			this.nome = nome;
			this.peso = peso;
			this.dataValidade = DateTime.Parse(dia + "/" + mes + "/" + ano);
		}

		public String Nome
		{
			get { return nome; }
		}

		public double Peso
		{
			get { return peso; }
		}

		public DateTime DataValidade
		{
			get { return dataValidade; }
		}

		public string FormattedDataValidade
		{
			get
			{
				return dataValidade.ToString("d");
			}
		}
	}
}
