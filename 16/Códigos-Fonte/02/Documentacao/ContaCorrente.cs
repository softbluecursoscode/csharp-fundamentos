using System;

namespace Documentacao
{
	/// <summary>
	/// Representa uma conta corrente.
	/// </summary>
	class ContaCorrente
	{
		/// <summary>
		/// Saldo atual da conta.
		/// </summary>
		public double Saldo { get; private set; }

		/// <summary>
		/// Construtor da classe.
		/// </summary>
		/// <param name="saldoInicial">Saldo inicial para a conta.</param>
		public ContaCorrente(double saldoInicial)
		{
			Saldo = saldoInicial;
		}

		/// <summary>
		/// Faz um depósito na conta.
		/// </summary>
		/// <param name="valor">Valor a ser depositado.</param>
		/// <exception cref="System.ArgumentException">Lançada quando o valor é 0 ou menor.</exception>
		public void Depositar(double valor)
		{
			if (valor <= 0)
			{
				throw new ArgumentException("Valor não pode 0 ou menor que 0");
			}

			Saldo += valor;
		}

		/// <summary>
		/// Bloqueia o saldo da conta.
		/// </summary>
		/// <returns>Retorna o saldo da conta.</returns>
		public double Bloquear()
		{
			return Saldo;
		}
	}
}
