using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria dois quadrados
			Quadrado q1 = new Quadrado(3.0);
			Quadrado q2 = new Quadrado(10.0);

			// Cria dois retângulos
			Retangulo r1 = new Retangulo(2.0, 7.0);
			Retangulo r2 = new Retangulo(5.0, 3.0);

			// Coloca as figuras num array de figuras
			Figura[] figuras = { q1, q2, r1, r2 };

			// Constroi uma figura complexa com base nas figuras criadas anteriormente
			FiguraComplexa figuraComplexa = new FiguraComplexa(figuras);

			// Calcula a área da figura complexa
			double area = figuraComplexa.CalcularArea();

			Console.WriteLine("Área da figura: " + area);
		}
	}

	abstract class Figura
	{
		// Calcula a área da figura. Este método é sobrecrito pelas subclasses.
		public abstract double CalcularArea();
	}

	class Quadrado : Figura
	{
		// Lado do quadrado
		private double lado;

		// Construtor que recebe o lado como parâmetro
		public Quadrado(double lado)
		{
			this.lado = lado;
		}

		// Método sobrescrito para calcular a área do quadrado
		public override double CalcularArea()
		{
			return lado * lado;
		}
	}

	class Retangulo : Figura
	{
		// Base do retângulo
		private double @base;

		// Altura do retângulo
		private double altura;

		// Construtor que recebe a base e a altura como parâmetros
		public Retangulo(double @base, double altura)
		{
			this.@base = @base;
			this.altura = altura;
		}

		// Método sobrescrito para calcular a área do retângulo
		public override double CalcularArea()
		{
			return @base * altura;
		}
	}

	// Representa uma figura complexa, isto é, é composta por outras figuras.
	// Repare que a própria figura complexa é também uma figura.
	// Além de ela SER uma figura (herança), ela TEM figuras (composição)
	class FiguraComplexa : Figura
	{
		// Figuras que compõem a figura complexa
		private Figura[] figuras;

		// Construtor que recebe o array de figuras
		public FiguraComplexa(Figura[] figuras)
		{
			this.figuras = figuras;
		}

		// Método sobrescrito para calcular a área total da figura.
		// A área total é a soma das áreas de todas as figuras.
		public override double CalcularArea()
		{
			double areaTotal = 0.0;

			for (int i = 0; i < figuras.Length; i++)
			{
				areaTotal += figuras[i].CalcularArea();
			}

			return areaTotal;
		}
	}
}
