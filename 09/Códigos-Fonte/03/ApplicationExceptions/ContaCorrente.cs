using System;

namespace ApplicationExceptions
{
	public class ContaCorrente
	{
		private double saldo;

		public void Sacar(double valor)
		{
			if (valor <= 0)
			{
				throw new ContaCorrenteException("Valor tem que ser maior que zero");
			}

			if (saldo - valor < 0)
			{
				throw new ContaCorrenteException("O saldo para saque é insuficiente");
			}

			saldo -= valor;
		}

		public void Depositar(double valor)
		{
			if (valor <= 0)
			{
				throw new ContaCorrenteException("Valor tem que ser maior que zero");
			}

			saldo += valor;
		}
	}
}
