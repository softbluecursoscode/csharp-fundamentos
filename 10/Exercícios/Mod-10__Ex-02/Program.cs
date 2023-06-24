using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Mostra as opções de bebidas.
			// O casting para int retorna o valor associado ao enum.
			Console.WriteLine(Bebida.Refrigerante + " - " + (int)Bebida.Refrigerante);
			Console.WriteLine(Bebida.Suco + " - " + (int)Bebida.Suco);
			Console.WriteLine(Bebida.Agua + " - " + (int)Bebida.Agua);
			Console.Write("Escolha uma bebida => ");

			// Solicita a opção
			int opcao;
			try
			{
				opcao = int.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				// Se a opção não for um número inteiro válido, termina o programa.
				Console.WriteLine("Você não digitou um número válido");
				return;
			}

			// Verifica se o número digitado faz parte do enum.
			bool exists = Enum.IsDefined(typeof(Bebida), opcao);

			if (exists)
			{
				// Faz o casting para Bebida, para obter o enum e mostra a opção escolhida.
				Bebida bebida = (Bebida)opcao;
				Console.WriteLine("Você escolheu a bebida " + bebida);
			}
			else
			{
				// Se o valor não existe no enum, mostra o erro.
				Console.WriteLine("A bebida escolhida não existe");
			}
		}
	}

	// Enum de bebidas.
	enum Bebida
	{
		Refrigerante = 1,
		Suco = 2,
		Agua = 3
	}
}
