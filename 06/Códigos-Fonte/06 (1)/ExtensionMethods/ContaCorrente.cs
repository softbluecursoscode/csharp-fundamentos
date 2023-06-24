using System;

namespace ExtensionMethods
{
	class ContaCorrente
	{
		public int NumConta { get; private set; }
		public int Agencia { get; private set; }
		public string Titular { get; set; }
		public double Saldo { get; private set; }

		public ContaCorrente(int numConta, int agencia)
		{
			this.NumConta = numConta;
			this.Agencia = agencia;
		}

		public void Sacar(double valor)
		{
			this.Saldo -= valor;
		}

		public void Depositar(double valor)
		{
			this.Saldo += valor;
		}
	}
}
