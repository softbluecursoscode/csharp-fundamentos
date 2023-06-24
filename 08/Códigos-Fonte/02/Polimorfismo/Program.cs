using System;

namespace Polimorfismo
{
	class Program
	{
		static void Main()
		{
			Animal a = new Cachorro();
			if (a is Cachorro)
			{
				Cachorro c1 = (Cachorro)a;
				c1.Morder();
			}
			else
			{
				Console.WriteLine("O casting nao pode ser feito");
			}

			Cachorro c2 = a as Cachorro;
			if (c2 != null)
			{
				c2.Morder();
			}
			else
			{
				Console.WriteLine("O casting nao pode ser feito");
			}
		}
	}

	public class Animal
	{
		public virtual void Falar()
		{
			Console.WriteLine("---");
		}
	}

	public class Cachorro : Animal
	{
		public override void Falar()
		{
			Console.WriteLine("Au-Au");
		}

		public void Morder()
		{
			Console.WriteLine("Nhac!");
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
