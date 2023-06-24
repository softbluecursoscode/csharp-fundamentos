using System;

namespace ExtensionMethods
{
	class Program
	{
		static void Main()
		{
			ContaCorrente c1 = new ContaCorrente(1234, 5656);
			c1.Titular = "Paulo Silva";
			c1.Depositar(200);
			c1.Sacar(50);

			c1.MostrarSaldo();

			ContaCorrente c2 = new ContaCorrente(3434, 4444);
			c1.Transferir(100, c2);
			c2.MostrarSaldo();
		}
	}
}
