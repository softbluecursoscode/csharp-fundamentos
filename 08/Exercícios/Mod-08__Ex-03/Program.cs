using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria diversos veículos (automóvel, motocicleta e ônibus). Liga cada um, exibe o valor 
			// do field 'ligado', desliga e exibe novamente o valor de 'ligado'

			Veiculo v1 = new Automovel();
			v1.Ligar();
			Console.WriteLine(v1.Ligado);
			v1.Desligar();
			Console.WriteLine(v1.Ligado);

			Veiculo v2 = new Motocicleta();
			v2.Ligar();
			Console.WriteLine(v2.Ligado);
			v2.Desligar();
			Console.WriteLine(v2.Ligado);

			Veiculo v3 = new Onibus();
			v3.Ligar();
			Console.WriteLine(v3.Ligado);
			v3.Desligar();
			Console.WriteLine(v3.Ligado);
		}
	}

	// Classe que representa um veículo genérico
	class Veiculo
	{
		// Indica se o veículo está ligado ou desligado
		private bool ligado;

		// Liga o veículo
		public virtual void Ligar()
		{
			ligado = true;
		}

		// Desliga o veículo
		public virtual void Desligar()
		{
			ligado = false;
		}

		// Read-only property
		public bool Ligado
		{
			get { return ligado; }
		}
	}

	// Classe que representa um automóvel
	class Automovel : Veiculo
	{
		// Perceba que, ao sobrescrever os métodos, o método da superclasse é chamado, pois ele precisa 
		// definir o valor correto para o field 'ligado'

		// Sobrescrita do método ligar()
		public override void Ligar()
		{
			base.Ligar();
			Console.WriteLine("Automóvel ligado");
		}

		// Sobrescrita do método desligar()
		public override void Desligar()
		{
			base.Desligar();
			Console.WriteLine("Automóvel desligado");
		}
	}

	// Classe que representa um ônibus
	class Onibus : Veiculo
	{
		// Perceba que, ao sobrescrever os métodos, o método da superclasse é chamado, pois ele precisa 
		// definir o valor correto para o field 'ligado'

		// Sobrescrita do método ligar()
		public override void Ligar()
		{
			base.Ligar();
			Console.WriteLine("Ônibus ligado");
		}

		// Sobrescrita do método desligar()
		public override void Desligar()
		{
			base.Desligar();
			Console.WriteLine("Ônibus desligado");
		}
	}

	// Classe que representa uma motocicleta
	class Motocicleta : Veiculo
	{
		// Perceba que, ao sobrescrever os métodos, o método da superclasse é chamado, pois ele precisa 
		// definir o valor correto para o field 'ligado'

		// Sobrescrita do método ligar()
		public override void Ligar()
		{
			base.Ligar();
			Console.WriteLine("Motocicleta ligada");
		}

		// Sobrescrita do método desligar()
		public override void Desligar()
		{
			base.Desligar();
			Console.WriteLine("Motocicleta desligada");
		}
	}
}
