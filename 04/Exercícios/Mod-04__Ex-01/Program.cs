using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria o relógio r1
			Relogio r1 = new Relogio();
		
			// Acerta o relógio com o horário 3:30:50
			r1.AcertarRelogio(3, 30, 50);
		
			// Mostra as posições dos ponteiros do relógio
			Console.WriteLine("Posição da hora: " + r1.ponteiroHora.posicao);
			Console.WriteLine("Posição do minuto: " + r1.ponteiroMinuto.posicao);
			Console.WriteLine("Posição do segundo: " + r1.ponteiroSegundo.posicao);
		
			// Mostra a hora, minuto e segundo do relógio, que devem ser 3, 30 e 50.
			int hora = r1.LerHora();
			int minuto = r1.LerMinuto();
			int segundo = r1.LerSegundo();
		
			Console.WriteLine("Hora: " + hora);
			Console.WriteLine("Minuto: " + minuto);
			Console.WriteLine("Segundo: " + segundo);
		
			// Cria o relógio r2
			Relogio r2 = new Relogio();
		
			// Acerta o relógio com o horário 22:00:00. O código transformará automaticamente para 10h
			r2.AcertarRelogio(22, 0, 0);
		
			// Lê a hora do relógio, que deve ser 10.
			Console.WriteLine("Hora do segundo relógio: " + r2.LerHora());
		}
	}
}

class Ponteiro
{
	// Posiçao do ponteiro do relógio (de 1 a 12)
	public int posicao;
}

class Relogio
{
	// Ponteiro das horas
	public Ponteiro ponteiroHora = new Ponteiro();

	// Ponteiro dos minutos
	public Ponteiro ponteiroMinuto = new Ponteiro();

	// Ponteiro dos segundos
	public Ponteiro ponteiroSegundo = new Ponteiro();

	// Acerta o relógio a partir de uma hora, minuto e segundo
	public void AcertarRelogio(int hora, int minuto, int segundo)
	{
		// A linha abaixo calcula o módulo da hora. Assim, se for fornecido 13, por exemplo, é
		// considerado hora 1.
		hora = hora % 12;

		// Acerta a posição de cada um dos ponteiros
		ponteiroHora.posicao = hora;
		ponteiroMinuto.posicao = minuto / 5;
		ponteiroSegundo.posicao = segundo / 5;
	}

	// Lê a hora do relógio
	public int LerHora()
	{
		return ponteiroHora.posicao;
	}

	// Lê o minuto do relógio
	public int LerMinuto()
	{
		return ponteiroMinuto.posicao * 5;
	}

	// Lê o segundo do relógio
	public int LerSegundo()
	{
		return ponteiroSegundo.posicao * 5;
	}
}
