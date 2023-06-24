using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria o baralho.
			Baralho baralho = CriarBaralho();

			// Embaralha as cartas.
			baralho.Embaralhar();

			Console.WriteLine("---- Cartas do baralho ----");

			// Mostras as cartas.
			baralho.MostrarCartas();

			// Distribui 3 cartas.
			// As cartas distribuídas são retornadas em um array.
			Carta[] cartasDistribuidas = baralho.Distribuir(3);

			Console.WriteLine("\n---- Cartas distribuídas ({0} carta(s))", cartasDistribuidas.Length);
			
			// Mostra as cartas distribuídas (devem ser as primeiras do baralho).
			foreach (Carta carta in cartasDistribuidas)
			{
				Console.WriteLine(carta);
			}

			Console.WriteLine("\n---- Cartas do baralho ----");

			// Mostra as cartas do baralho.
			// As cartas já distribuídas não fazem mais parte do baralho.
			baralho.MostrarCartas();

			baralho.Embaralhar();
			Console.WriteLine("\n---- Cartas do baralho ----");
			baralho.MostrarCartas();
		}

		private static Baralho CriarBaralho()
		{
			// Números das cartas do baralho (de 1 a numCartas).
			int numCartas = 2;

			// Número de naipes existentes.
			// O método GetNames() retorna um array de strings com os elementos do enum. Length lê o tamanho do array.
			int numNaipes = Enum.GetNames(typeof(Carta.Naipe)).Length;

			// Cria um array de cartas com o tamanho numCartas * numNaipes.
			Carta[] cartas = new Carta[numCartas * numNaipes];
			
			// A variável i controla a inserção no array de cartas.
			int i = 0;

			// Itera sobre os valores.
			for (int valor = 1; valor <= numCartas; valor++)
			{
				// Itera sobre os naipes
				for (int naipe = 0; naipe < numNaipes; naipe++)
				{
					// Cria a carta com o valor e naipe especificado.
					// O casting de naipe para Carta.Naipe converte o int para um elemento do enum.
					cartas[i] = new Carta(valor, (Carta.Naipe)naipe);
					i++;
				}
			}

			// Cria o baralho e retorna.
			Baralho baralho = new Baralho(cartas);
			return baralho;
		}
	}
}
