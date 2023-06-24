using System;

namespace Heranca
{
	class Animal
	{
		public double Altura { get; set; }
		public double Peso { get; set; }

		protected string nome;

		public void Mover()
		{
			Console.WriteLine("Animal " + nome + " se moveu");
		}

		public void MostrarDados()
		{
			Console.WriteLine("Altura = " + Altura + ", Peso = " + Peso);
		}
	}
}
