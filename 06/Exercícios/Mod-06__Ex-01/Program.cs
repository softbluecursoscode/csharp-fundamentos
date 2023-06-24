using System;


namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Instancia uma lâmpada acesa
			Lampada l = new Lampada(true);

			// Imprime o estado atual
			l.Imprimir();

			// Desliga a lâmpada e imprime o novo estado
			l.Desligar();
			l.Imprimir();

			// Liga a lâmpada e imprime o novo estado
			l.Ligar();
			l.Imprimir();
		}
	}

	class Lampada
	{
		// Armazena o estado atual da lâmpada. Este field é privado porque só deve 
		// ser visível dentro desta classe
		private bool ligada;

		// Construtor. Recebe como parâmetro o estado inicial da lâmpada
		public Lampada(bool ligada)
		{
			// Utiliza o operador this para diferenciar o atributo do parâmetro
			this.ligada = ligada;
		}

		// Liga a lâmpada
		public void Ligar()
		{
			ligada = true;
		}

		// Desliga a lâmpada
		public void Desligar()
		{
			ligada = false;
		}

		// Imprime o estado atual da lâmpada
		public void Imprimir()
		{
			if (ligada)
			{
				Console.WriteLine("Lâmpada ligada");
			}
			else
			{
				Console.WriteLine("Lâmpada desligada");
			}
		}
	}
}
