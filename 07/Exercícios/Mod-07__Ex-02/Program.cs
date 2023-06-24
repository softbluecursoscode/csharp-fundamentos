using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria uma porta e a abre
			Porta p1 = new Porta(2.1, 0.9);
			p1.Abrir();
		
			// Imprime os valores dos fields
			Console.WriteLine("p1 -> altura = " + p1.Altura);
			Console.WriteLine("p1 -> largura = " + p1.Largura);
			Console.WriteLine("p1 -> aberta = " + p1.Aberta);
		
			// Cria uma cópia de p1. O método Clone() retorna um object, portanto o casting é necessário
			Porta p2 = (Porta) p1.Clone();
		
			// Imprime os valores dos atributos do objeto copiado. Devem ser os mesmos do objeto original
			Console.WriteLine("p2 -> altura = " + p2.Altura);
			Console.WriteLine("p2 -> largura = " + p2.Largura);
			Console.WriteLine("p2 -> aberta = " + p2.Aberta);
		}
	}

	class Porta : ICloneable
	{
		// Altura
		private double altura;

		// Largura
		private double largura;

		// Porta aberta?
		private bool aberta;

		// Construtor que recebe a altura e largura da porta
		public Porta(double altura, double largura)
		{
			this.altura = altura;
			this.largura = largura;

			// Inicialmente a porta está fechada
			this.aberta = false;
		}

		// Abre a porta
		public void Abrir()
		{
			aberta = true;
		}

		// Fecha a porta
		public void Fechar()
		{
			aberta = false;
		}

		// Property Altura
		public double Altura
		{
			get { return altura; }
		}

		// Property Largura
		public double Largura
		{
			get { return largura; }
		}

		// Property Aberta
		public bool Aberta
		{
			get { return aberta; }
		}

		public object Clone()
		{
			// Cria um novo objeto e copia os valores dos atributos para este novo objeto
			Porta p = new Porta(this.altura, this.largura);
			p.aberta = this.aberta;

			// Retorna o novo objeto, que é uma cópia do objeto anterior
			return p;
		}
	}
}
