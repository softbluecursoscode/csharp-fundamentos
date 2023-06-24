using System;

namespace Construtores
{
	class Program
	{
		static void Main()
		{
			Salario s = new Salario(2000, 0.2, 5);

			Console.WriteLine(s.valor);
			Console.WriteLine(s.mes);
		}
	}

	class Salario
	{
		public double valor;
		public int mes;

		public Salario(double valor, double bonus)
		{
			Console.WriteLine("Criando objeto (2)");
			this.valor = valor + valor * bonus;
		}

		public Salario(double valor, double bonus, int mes) : this(valor, bonus)
		{
			Console.WriteLine("Criando objeto (3)");
			this.mes = mes;
		}

		public Salario()
		{
			Console.WriteLine("Criando objeto (0)");
		}

		public void MostrarValor()
		{
			Console.WriteLine(valor);
		}
	}
}
