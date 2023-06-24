using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria a fração 5/2
			Fracao f1 = new Fracao();
			f1.DefinirValores(5, 2);
		
			// Cria a fração 1/7
			Fracao f2 = new Fracao();
			f2.DefinirValores(1, 7);
		
			// Multiplica as frações
			Fracao f3 = f1.Multiplicar(f2);
		
			// Mostra a fração
			Console.WriteLine(f3.ObterFracao());
		
			// Mostra o valor da fração (divisão)
			Console.WriteLine(f3.CalcularValor());
		}
	}
}

public struct Fracao
{
	// Numerador da fração
	double numerador;

	// Denominador da fração
	double denominador;

	// Calcula o valor do fração
	public double CalcularValor()
	{
		// Para calcular o valor, basta dividir o numerador da fração pelo denominador. Se o denominador 
		// for 0, o resultado é assumido como 0, já que não é possível fazer uma divisão por 0.
		if (denominador == 0)
		{
			return 0;
		}
		return numerador / denominador;
	}

	 // Multiplica a fração atual por outra, dando uma terceira fração como resultado.
	public Fracao Multiplicar(Fracao f)
	{
		// Cria uma nova estrutura que vai conter o resultado
		Fracao result = new Fracao();

		// Multiplica os numeradores e denominadores das frações
		result.numerador = numerador * f.numerador;
		result.denominador = denominador * f.denominador;

		// Retorna a nova fração
		return result;
	}

	//Define os valores do numerador e denominador da fração
	public void DefinirValores(double numerador, double denominador)
	{
		this.numerador = numerador;
		this.denominador = denominador;
	}

	// Retorna a representação da fração em forma de texto
	public string ObterFracao()
	{
		return numerador + "/" + denominador;
	}
}
