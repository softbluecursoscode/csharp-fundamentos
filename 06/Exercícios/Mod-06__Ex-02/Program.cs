using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{

			// Cria a data/hora 10/03/2000 10:30:10
			Data d1 = new Data(10, 03, 2000, 10, 30, 10);
			d1.Imprimir(Data.FORMATO_12H);
			d1.Imprimir(Data.FORMATO_24H);

			// Cria a data/hora 15/06/2000 23:15:20
			Data d2 = new Data(15, 06, 2000, 23, 15, 20);
			d2.Imprimir(Data.FORMATO_12H);
			d2.Imprimir(Data.FORMATO_24H);

			// Cria a data 05/10/2005
			Data d3 = new Data(5, 10, 2005);
			d3.Imprimir(Data.FORMATO_12H);
			d3.Imprimir(Data.FORMATO_24H);
		}
	}

	public class Data
	{
		// Constantes para os formatos de 12h e 24h

		public const int FORMATO_12H = 1;
		public const int FORMATO_24H = 2;

		// Fields que representam os elementos da data/hora

		private int dia;
		private int mes;
		private int ano;
		private int hora = -1;
		private int minuto = -1;
		private int segundo = -1;

		// Construtor que recebe dia, mes e ano
		public Data(int dia, int mes, int ano)
		{
			this.dia = dia;
			this.mes = mes;
			this.ano = ano;
		}

		// Construtor completo, que recebe informações de data e horário (chama o outro construtor da classe)
		public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
		{
			this.hora = hora;
			this.minuto = minuto;
			this.segundo = segundo;
		}

		// Imprime a data/hora formatada (de acordo com o formato especificado)
		public void Imprimir(int formato)
		{
			// Monta a string de impressão de data
			string data = dia + "/" + mes + "/" + ano;

			if (hora == -1)
			{
				// Se hora for -1, significa que os dados de horário não foram passado no construtor.
				// Então exibe só a data
				Console.WriteLine(data);
			}
			else
			{
				// Monta parte da string da horário (deixa a hora de fora por enquanto)
				String horario = ":" + minuto + ":" + segundo;

				if (formato == FORMATO_24H)
				{
					// Se o formato for 24h, concatena a hora no início da string (o atributo já foi
					// fornecido no formato 24h)
					horario = hora + horario;
				}
				else
				{
					// Se o formato for 12h
					if (hora >= 12)
					{
						// Se hora for maior ou igual a 12, é preciso subtrair 12 da hora para obter 
						// a hora no formato 12h, e concatena o "PM" no fim
						horario = (hora - 12) + horario;
						horario += " PM";
					}
					else
					{
						// Se a hora for menor que 12, simplesmente utiliza a própria hora e concatena
						// o "AM" no fim
						horario = hora + horario;
						horario += " AM";
					}
				}

				// Imprime a data/hora formatada
				Console.WriteLine(data + " " + horario);
			}
		}

		// Read-only Properties

		public int Dia
		{
			get { return dia; }
		}

		public int Mes
		{
			get { return mes; }
		}

		public int Ano
		{
			get { return ano; }
		}

		public int Hora
		{
			get { return hora; }
		}

		public int Minuto
		{
			get { return minuto; }
		}

		public int Segundo
		{
			get { return segundo; }
		}
	}
}
