using System;

namespace Properties
{
	class Program
	{
		static void Main()
		{
			Endereco1 e = new Endereco1();
			e.Logradouro = "R. dos Programadores";
			e.Numero = 250;
			e.Apartamento = true;

			Endereco2 e2 = new Endereco2();
			e2.Logradouro = "R. dos Programadores";
			e2.Numero = 250;
			e2.Apartamento = true;
		}
	}

	class Endereco2
	{
		public string Logradouro { get; set; }
		public int Numero { get; set; }
		public bool Apartamento { get; set; }
	}

	class Endereco1
	{
		private string logradouro;
		private int numero;
		private bool apartamento;

		public string Logradouro
		{
			get
			{
				return logradouro;
			}
			set
			{
				logradouro = value;
			}
		}

		public int Numero
		{
			get
			{
				return numero;
			}
			set
			{
				numero = value;
			}
		}

		public bool Apartamento
		{
			get
			{
				return apartamento;
			}
			set
			{
				apartamento = value;
			}
		}
	}
}
