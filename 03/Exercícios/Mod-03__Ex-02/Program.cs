using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Contador de notas digitadas
			int c = 1;

			// Soma das parciais (nota * peso)
			double parcial = 0.0;

			// Soma dos pesos digitados
			double somaPesos = 0.0;

			// O loop é infinito, será finalizado apenas no break
			while (true)
			{
				// Solicita a nota
				Console.Write("Nota " + c + ": ");
				double nota = double.Parse(Console.ReadLine());

				// Se a nota for -1, sai do loop
				if (nota == -1)
				{
					break;
				}

				// Solicita o peso
				Console.Write("Peso " + c + ": ");
				double peso = double.Parse(Console.ReadLine());

				// Acumula o cálculo parcial, somando o que já foi calculado e (nota * peso)
				parcial += nota * peso;

				// Acumula a soma dos pesos
				somaPesos += peso;
				
				// Incrementa o contador de notas
				c++;
			}

			// Checa se somaPesos é maior que 0, para evitar divisão por 0
			if (somaPesos > 0)
			{
				// Calcula a média, dividindo o cálculo da parcial pela soma dos pesos
				double media = parcial / somaPesos;

				// Exibe a média
				Console.WriteLine("Média do aluno: " + media);
			}
		}
	}
}
