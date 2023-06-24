using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			//Valor para o qual o fatorial será calculado
			int valor = 10;
		
			// Variável para acumular o resultado do fatorial
			long resposta = 1;
	
			// No bloco for, o valor já calculado (variável resposta) é multiplicado com o valor de i,
			// que é o número corrente da iteração.
			for (int i = 2; i <= valor; i++) {
				resposta *= i;
			}

			Console.WriteLine("O fatorial de " + valor + " é igual a " + resposta);


			// Esta é outra implementação do mesmo exercício, que calcula o fatorial do valor de forma recursiva.
			// Esta é uma forma alternativa de cálculo, onde o método calcularFatorial() chama ele próprio (recursão).
			// (Esta implementação está sendo mostrada como curiosidade. Você ainda vai aprender a respeito de métodos no curso.)
			resposta = calcularFatorial(valor);

			Console.WriteLine("O fatorial de " + valor + " é igual a " + resposta);
		}

		// Uma das formas de implementar o cálculo do fatorial é utilizar uma chamada recursiva, isto é,
		// o método chama ele mesmo.
		static long calcularFatorial(int num)
		{
			if (num == 0)
			{
				// Para num == 0, o fatorial é 1.
				return 1;
			}

			// Caso contrário, o fatorial é o número multiplicado pelo fatorial do seu antecessor.
			return num * calcularFatorial(num - 1);
		}
	}
}
