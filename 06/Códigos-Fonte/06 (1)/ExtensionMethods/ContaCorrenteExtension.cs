using System;

namespace ExtensionMethods
{
	static class ContaCorrenteExtension
	{
		public static void Transferir(this ContaCorrente conta, double valor, ContaCorrente contaDestino)
		{
			conta.Sacar(valor);
			contaDestino.Depositar(valor);
		}

		public static void MostrarSaldo(this ContaCorrente conta)
		{
			Console.WriteLine(conta.Saldo);
		}
	}
}
