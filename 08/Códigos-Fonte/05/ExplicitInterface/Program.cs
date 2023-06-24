using System;

namespace ExplicitInterface
{
	class Program
	{
		static void Main()
		{
			Objeto o = new Objeto();
			//o.EmitirSom();

			IAnimal a = (IAnimal)o;
			a.EmitirSom();

			IBrinquedo b = (IBrinquedo)o;
			b.EmitirSom();
		}
	}

	class Objeto : IAnimal, IBrinquedo
	{
		void IAnimal.EmitirSom()
		{
			Console.WriteLine("Animal emitiu som");
		}

		void IBrinquedo.EmitirSom()
		{
			Console.WriteLine("Brinquedo emitiu som");
		}
	}
}
