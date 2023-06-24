using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Criação das contas bancárias
			ContaBancaria c1 = new ContaBancaria();
			ContaBancaria c2 = new ContaBancaria();

			// Depósito de 100 em c1. OK
			try
			{
				c1.Depositar(100);
				Console.WriteLine("Depósito de 100 feito com sucesso em c1");
			}
			catch (ValorInvalidoException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Valor inválido: " + e.ValorInvalido);
			}

			// Depósito de -10 em c1. Falha por causa do valor negativo.
			try
			{
				c1.Depositar(-10);
				Console.WriteLine("Depósito de -10 feito com sucesso em c1");
			}
			catch (ValorInvalidoException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Valor inválido: " + e.ValorInvalido);
			}

			// Saque de 30 em c1. OK
			try
			{
				c1.Sacar(30);
				Console.WriteLine("Saque de 30 feito com sucesso em c1");
			}
			catch (ValorInvalidoException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Valor inválido: " + e.ValorInvalido);
			}
			catch (SaldoInsuficienteException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Saldo disponível: " + e.SaldoDisponivel);
			}

			// Saque de 90 em c1. Falha porque o saldo é insuficiente
			try
			{
				c1.Sacar(90);
				Console.WriteLine("Saque de 90 feito com sucesso em c1");
			}
			catch (ValorInvalidoException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Valor inválido: " + e.ValorInvalido);
			}
			catch (SaldoInsuficienteException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Saldo disponível: " + e.SaldoDisponivel);
			}

			// Saque de -5 em c1. Falha por causa do valor negativo
			try
			{
				c1.Sacar(-5);
				Console.WriteLine("Saque de -5 feito com sucesso em c1");
			}
			catch (ValorInvalidoException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Valor inválido: " + e.ValorInvalido);
			}
			catch (SaldoInsuficienteException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Saldo disponível: " + e.SaldoDisponivel);
			}

			// Transferência de 50 de c1 para c2. OK
			try
			{
				c1.Transferir(50, c2);
				Console.WriteLine("Transferência de 50 de c1 para c2 feita com sucesso");
			}
			catch (ValorInvalidoException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Valor inválido: " + e.ValorInvalido);
			}
			catch (SaldoInsuficienteException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Saldo disponível: " + e.SaldoDisponivel);
			}

			// Transferência de 50 de c1 para c2. Falha porque o saldo é insuficiente
			try
			{
				c1.Transferir(50, c2);
				Console.WriteLine("Transferência de 50 de c1 para c2 feita com sucesso");
			}
			catch (ValorInvalidoException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Valor inválido: " + e.ValorInvalido);
			}
			catch (SaldoInsuficienteException e)
			{
				Console.WriteLine("Erro: " + e.Message + ". Saldo disponível: " + e.SaldoDisponivel);
			}
		}
	}

	// Classe que representa uma conta bancária
	class ContaBancaria
	{
		// Saldo da conta
		private double saldo;

		// Deposita um valor na conta
		public void Depositar(double valor)
		{
			// Se o valor for negativo, lança uma exceção
			if (valor <= 0)
			{
				throw new ValorInvalidoException("Valor inválido para depósito", valor);
			}

			saldo += valor;
		}

		// Saca um valor da conta
		public void Sacar(double valor)
		{
			// Se o valor for negativo, lança uma exceção
			if (valor <= 0)
			{
				throw new ValorInvalidoException("Valor inválido para saque", valor);
			}

			// Se não houver saldo suficiente para o saque, lança uma exceção
			if (saldo - valor < 0)
			{
				throw new SaldoInsuficienteException("Não há saldo suficiente disponível", saldo);
			}

			saldo -= valor;
		}

		// Transfere um valor desta conta para outra
		// Este método pode lançar SaldoSuficienteException e ValorInvalidoException porque os métodos Sacar() e 
		// Depositar(), chamados por ele, podem lançar estas exceções
		public void Transferir(double valor, ContaBancaria conta)
		{
			Sacar(valor);
			conta.Depositar(valor);
		}
	}

	// Exceção que representa um valor inválido
	class ValorInvalidoException : Exception
	{
		// Valor inválido utilizado
		private double valorInvalido;

		// Construtor. Recebe uma mensagem de erro e o valor inválido utilizado
		public ValorInvalidoException(string message, double valorInvalido)
			: base(message)
		{
			this.valorInvalido = valorInvalido;
		}

		// Obtém o valor inválido utilizado
		public double ValorInvalido
		{
			get { return valorInvalido; }
		}
	}

	// Exceção que representa uma quantidade de saldo insuficiente na conta para realizar a transação
	class SaldoInsuficienteException : Exception
	{
		// Saldo total disponível na conta
		private double saldoDisponivel;

		// Construtor. Recebe uma mensagem de erro e o saldo disponível
		public SaldoInsuficienteException(String message, double saldoDisponivel)
			: base(message)
		{
			this.saldoDisponivel = saldoDisponivel;
		}

		// Obtém o saldo disponível
		public double SaldoDisponivel
		{
			get { return saldoDisponivel; }
		}
	}
}
