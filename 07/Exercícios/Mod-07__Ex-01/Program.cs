using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria um ponto 2D
			Ponto2D p1 = new Ponto2D(10, 2);
		
			// Imprime p1
			Console.WriteLine(p1.Imprimir());

			// Cria um ponto 3D
			Ponto3D p2 = new Ponto3D(5, 2, 1);
		
			// Imprime p2
			Console.WriteLine(p2.Imprimir());
		}
	}

	class Ponto2D
	{
		// Coordenada x
		private double x;

		// Coordenada y
		private double y;

		// Construtor que recebe as coordenadas
		public Ponto2D(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		// Property X
		public double X
		{
			get { return x; }
		}

		// Property Y
		public double Y
		{
			get { return y; }
		}

		// Método Imprimir(), que imprime os valores de x e y
		public string Imprimir()
		{
			return "x = " + X + ", y = " + Y;
		}
	}

	// Um Ponto3D é um Ponto2D, com a diferença de que ele possui uma dimensão a mais.
	// Portanto Ponto3D  pode herdar de Ponto2D
	class Ponto3D : Ponto2D
	{
		// Coordenada z
		private double z;

		// Construtor (invoca o construtor de Ponto2D)
		public Ponto3D(double x, double y, double z)
			: base(x, y)
		{
			this.z = z;
		}

		// Property Z
		public double Z
		{
			get { return z; }
		}

		// Método Imprimir(), que imprime os valores de x e y
		public string Imprimir()
		{
			return "x = " + X + ", y = " + Y + ", z = " + Z;
		}
	}
}
