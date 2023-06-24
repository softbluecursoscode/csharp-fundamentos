using System;

namespace ConstrutorHeranca
{
	class Program
	{
		static void Main()
		{
			Passaro p = new Passaro(0.2);
		}
	}

	class Animal
	{
		public Animal(double altura) : base()
		{
			Console.WriteLine("Animal()");
		}
	}

	class AnimalAlado : Animal
	{
		public AnimalAlado(double altura) : base(altura)
		{
			Console.WriteLine("AnimalAlado()");
		}
	}

	class Passaro : AnimalAlado
	{
		public Passaro(double altura) : base(altura)
		{
			Console.WriteLine("Passaro()");
		}
	}
}
