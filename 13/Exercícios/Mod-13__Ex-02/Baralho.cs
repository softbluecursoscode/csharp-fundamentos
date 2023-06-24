using System;

namespace Softblue
{
	// Representa o baralho de cartas.
	class Baralho
	{
		// Gerador de números randômicos.
		private Random random = new Random();
		
		// Array de cartas.
		private Carta[] cartas;

		// Índice do array que corresponde à primeira carta do baralho.
		private int posPrimeiraCarta;

		// Array que controla os índices já sorteados na hora de embaralhar as cartas.
		private int[] randomIndexes;

		// Construtor que recebe as cartas como parâmetro.
		public Baralho(Carta[] cartas)
		{
			this.cartas = cartas;
		}

		// Mostra as cartas do baralho.
		public void MostrarCartas()
		{
			// As cartas já distribuídas não são mais mostradas, pois não fazem mais parte do baralho
			for (int i = posPrimeiraCarta; i < cartas.Length; i++)
			{
				Console.WriteLine(cartas[i]);
			}
		}

		// Embaralha as cartas.
		public void Embaralhar()
		{
			// Cria um novo array de cartas. O tamanho dele vai ser igual ou menor do que o array original (se cartas 
			// já foram distribuídas ele será menor).
			Carta[] cartasEmbaralhadas = new Carta[cartas.Length - posPrimeiraCarta];

			// Instancia o array de controle de índices e inicializa os elementos com -1.
			randomIndexes = new int[cartasEmbaralhadas.Length];
			for (int i = 0; i < randomIndexes.Length; i++)
			{
				randomIndexes[i] = -1;
			}

			// Variável para controlar a inserção no array de controle de índices.
			int j = 0;

			// Itera sobre o novo array, colocando as cartas de forma randômica.
			for (int i = 0; i < cartasEmbaralhadas.Length; i++)
			{
				// É preciso selecionar um índice do array de cartas de forma randômica. Apenas os elementos a partir
				// da primeira carta devem ser considerados, pois os elementos anteriores a este representam cartas
				// ja distribuídas.
				int randomIndex;
				do 
				{
					randomIndex = random.Next(posPrimeiraCarta, cartas.Length);

					// Pode ocorrer de um mesmo índice ser sorteado mais de uma vez através do Next(). O método JaSorteado()
					// verifica se este índice já foi sorteado anteriormente.

				} while (JaSorteado(randomIndex));

				// Adiciona o índice escolhido no array de controle de índices sorteados e incrementa a variável j.
				randomIndexes[j] = randomIndex;
				j++;
				
				// Armazena o elemento do array original no novo array.
				cartasEmbaralhadas[i] = cartas[randomIndex];
			}

			// O novo array criado passa a ser o array de cartas do baralho.
			cartas = cartasEmbaralhadas;

			// Como agora existe um novo array, o índice da primeira carta volta a ser 0.
			posPrimeiraCarta = 0;
		}

		// Distribui cartas do baralho. O parâmetro qtde indica quantas cartas devem ser distribuídas.
		// Retorna um array de cartas distribuídas. Estas cartas deixam de fazer parte do baralho.
		public Carta[] Distribuir(int qtde)
		{
			// A quantidade a ser distribuída deve ser maior do que 0.
			if (qtde <= 0)
			{
				throw new ArgumentOutOfRangeException("A quantidade para distribuição é inválida");
			}

			// A quantidade deve ser menor ou igual ao número de cartas existentes no baralho.
			if (qtde > this.cartas.Length - posPrimeiraCarta)
			{
				throw new ArgumentOutOfRangeException("A quantidade a ser distribuída excede o número de cartas do baralho");
			}

			// Cria um array de cartas de acordo com a quantidade fornecida.
			Carta[] cartas = new Carta[qtde];

			// Itera sobre o array adicionando as cartas
			for (int i = 0; i < cartas.Length; i++)
			{
				// As cartas devem ser distribuídas sempre a partir da primeira carta, cujo índice está armazenado em
				// posPrimeiraCarta.
				cartas[i] = this.cartas[posPrimeiraCarta];
				
				// Incrementa o índice da primeira carta.
				posPrimeiraCarta++;
			}

			// Retorna as cartas distribuídas.
			return cartas;
		}

		// Verifica se o índice passado como parâmetro está presente dentro do array de controle de índices
		private bool JaSorteado(int index)
		{
			foreach (int i in randomIndexes)
			{
				if (index == i)
				{
					return true;
				}
			}
			return false;
		}
	}
}
