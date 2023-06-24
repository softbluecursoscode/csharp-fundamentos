using System;

namespace ClassesAbstratas
{
	public abstract class Bebida
	{
		public void Preparar()
		{
			Console.WriteLine("Início da preparação");
			AdicionarAgua();
			AdicionarSubstancia();
			AdicionarAcucar();
			Console.WriteLine("Bebida preparada");
		}

		public abstract void AdicionarAgua();
		public abstract void AdicionarSubstancia();
		public abstract void AdicionarAcucar();
	}

	public class Cafe : Bebida
	{
		public override void AdicionarAgua()
		{
			Console.WriteLine("Adicionando água para o café");
		}

		public override void AdicionarSubstancia()
		{
			Console.WriteLine("Adicionando café");
		}

		public override void AdicionarAcucar()
		{
			Console.WriteLine("Adicionando açúcar ao café");
		}
	}

	public class Cha : Bebida
	{
		public override void AdicionarAgua()
		{
			Console.WriteLine("Adicionando água para o chá");
		}

		public override void AdicionarSubstancia()
		{
			Console.WriteLine("Adicionando chá");
		}

		public override void AdicionarAcucar()
		{
			Console.WriteLine("Adicionando açúcar ao chá");
		}
	}
}
