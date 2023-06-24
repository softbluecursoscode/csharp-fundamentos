using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria duas contas bancárias. Primeiro deposita 1000 e saca 200 de cada uma delas e calcula o 
			// saldo. Depois transfere 100 da conta 1 para a conta 2 e calcula o saldo das duas.

			ContaBancaria c1 = new ContaCorrente();
			c1.Depositar(1000);
			c1.Sacar(200);
			double saldo = c1.CalcularSaldo();
			Console.WriteLine("Saldo da conta 1: " + saldo);

			ContaBancaria c2 = new ContaInvestimento();
			c2.Depositar(1000);
			c2.Sacar(200);
			saldo = c2.CalcularSaldo();
			Console.WriteLine("Saldo da conta 2: " + saldo);

			c1.Transferir(100, c2);
			saldo = c1.CalcularSaldo();
			Console.WriteLine("Saldo da conta 1: " + saldo);
			saldo = c2.CalcularSaldo();
			Console.WriteLine("Saldo da conta 2: " + saldo);
		}
	}

	// Classe que representa uma conta bancária genérica. Por ser abstrata, não pode ser instanciada
	abstract class ContaBancaria
	{
		// Saldo da conta
		protected double Saldo { get; set; }

		// Deposita determinado valor na conta
		public void Depositar(double valor)
		{
			Saldo += valor;
		}

		// Saca determinado valor da conta
		public void Sacar(double valor)
		{
			Saldo -= valor;
		}

		// Transfere determinado valor para outra conta
		public void Transferir(double valor, ContaBancaria conta)
		{
			Sacar(valor);
			conta.Depositar(valor);
		}

		// Calcula o saldo final, que pode sofrer variação do valor armazenado no atributo
		// 'saldo'. Cada subclasse deve implementar este método de acordo com suas regras de cálculo
		public abstract double CalcularSaldo();
	}

	// Classe que representa uma conta corrente
	class ContaCorrente : ContaBancaria
	{
		// Implementa o cálculo do saldo, diminuindo 10% do saldo real (impostos)
		public override double CalcularSaldo()
		{
			return Saldo - (Saldo * 0.1);
		}
	}

	// Classe que representa uma conta investimento
	class ContaInvestimento : ContaBancaria
	{
		// Implementa o cálculo do saldo, aumentando 5% sobre o saldo real (rendimentos)
		public override double CalcularSaldo()
		{
			return Saldo + (Saldo * 0.05);
		}
	}
}
