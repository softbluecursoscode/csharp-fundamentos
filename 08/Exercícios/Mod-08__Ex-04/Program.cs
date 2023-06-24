using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Área da figura
			double area;
		
			// O código abaixo usa polimorfismo para referenciar o objeto criado na memória. Isto possibilita
			// que o código enxergue todos os objetos de uma forma homogênea, não interessando qual o tipo real
			// do objeto criado na memória (o código referencia apenas um objeto AreaCalculavel).
				
			// Área de um quadrado de lado 2
			IAreaCalculavel a1 = new Quadrado(2);
			area = a1.CalcularArea();
			Console.WriteLine(area);
		
			// Área de um retrângulo de lados 3 e 2
			IAreaCalculavel a2 = new Retangulo(3, 2);
			area = a2.CalcularArea();
			Console.WriteLine(area);
		
			// Área de uma circunferência de raio 3
			IAreaCalculavel a3 = new Circunferencia(3);
			area = a3.CalcularArea();
			Console.WriteLine(area);
		}
	}

	interface IAreaCalculavel
	{
		// Método para calcular área. Deve ser implementado pelas classes que implementam esta interface
		double CalcularArea();
	}

	class Quadrado : IAreaCalculavel
	{
		// Lado do quadrado
		private double lado;

		// Construtor
		public Quadrado(double lado)
		{
			this.lado = lado;
		}

		//cálculo da área do quadrado
		public double CalcularArea()
		{
			return lado * lado;
		}
	}

	class Retangulo : IAreaCalculavel
	{
		// Base e altura do retângulo
		private double @base;
		private double altura;

		// Construtor
		public Retangulo(double @base, double altura)
		{
			this.@base = @base;
			this.altura = altura;
		}

		// Cálculo da área do retângulo
		public double CalcularArea()
		{
			return @base * altura;
		}
	}

	class Circunferencia : IAreaCalculavel
	{
		// Raio da circunferência
		private double raio;

		// Construtor
		public Circunferencia(double raio)
		{
			this.raio = raio;
		}

		// Cálculo da área da circunferência
		public double CalcularArea()
		{
			return Math.PI * raio * raio;
		}
	}
}
