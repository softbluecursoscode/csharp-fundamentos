using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Solicita a nota 1 e peso 1.
			Console.Write("Nota 1: ");
			double nota1 = double.Parse(Console.ReadLine());
			Console.Write("Peso 1: ");
			double peso1 = double.Parse(Console.ReadLine());

			// Solicita a nota 2 e peso 2.
			Console.Write("Nota 2: ");
			double nota2 = double.Parse(Console.ReadLine());
			Console.Write("Peso 2: ");
			double peso2 = double.Parse(Console.ReadLine());

			// Solicita a nota 3 e peso 3.
			Console.Write("Nota 3: ");
			double nota3 = double.Parse(Console.ReadLine());
			Console.Write("Peso 3: ");
			double peso3 = double.Parse(Console.ReadLine());

			// Calcula e exibe a média.
			double media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
			Console.WriteLine("Média do aluno: " + media);
		}
	}
}
