using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Variáveis para armazenar dia, mês e ano (digitados pelo usuário)
			Console.Write("Dia: ");
			int dia = int.Parse(Console.ReadLine());
			Console.Write("Mês: ");
			int mes = int.Parse(Console.ReadLine());
			Console.Write("Ano: ");
			int ano = int.Parse(Console.ReadLine());

			// Datas consideradas inválidas são datas cujo ano seja menor que 1900 ou maior que 2999
			// ou que o mês seja menor que 1 ou maior que 12.
			if (ano < 1900 || ano > 2999 || mes < 1 || mes > 12)
			{
				Console.WriteLine("Data inválida");

			}
			else if ((dia <= 31) && (mes <= 12))
			{
				// Se o mês for 2 e o dia maior que 28, a data é inválida. Ou então se o dia for 31
				// e o mês for um dos meses que tem 30 dias, a data também é inválida.
				if (((dia > 28) && (mes == 2))
						|| ((dia == 31) && ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))))
				{
					Console.WriteLine("Data inválida");
				}
				else
				{
					//caso contrário ela é válida
					Console.WriteLine("Data válida");
				}

			}
			else
			{
				Console.WriteLine("Data inválida");
			}
		}
	}
}
