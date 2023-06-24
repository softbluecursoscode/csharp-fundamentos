using System;

namespace ClassesAbstratas
{
	class Program
	{
		static void Main()
		{
			Cafe c = new Cafe();
			c.Preparar();

			Cha cha = new Cha();
			cha.Preparar();
		}
	}

	public abstract class Animal
	{
		public abstract void Falar();
	}

	public class Cachorro : Animal
	{
		public override void Falar()
		{
			Console.WriteLine("Au-Au");
		}
	}

	public class Gato : Animal
	{
		public override void Falar()
		{
			Console.WriteLine("Miau");
		}
	}
}
