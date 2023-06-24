using System;

namespace Softblue
{
	/// <summary>
	/// Controla a execução do jogo.
	/// </summary>
	class Game
	{
		/// <summary>
		/// Tabuleiro.
		/// </summary>
		private Board board = new Board();
		
		/// <summary>
		/// Jogadores do jogo (2).
		/// </summary>
		private Player[] players = new Player[2];
		
		/// <summary>
		/// Índice do jogador ativo (começa com -1).
		/// </summary>
		private int activePlayerIndex = -1;

		/// <summary>
		/// Inicia o jogo.
		/// </summary>
		public void Play()
		{
			// Muda as cores do console.
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Clear();

			// Lê o nome dos jogadores via console.
			ReadPlayerNames();

			// Loop do jogo, que executa enquanto o jogo não terminar.
			BoardItem? winnerBoardItem;
			while (!board.IsFinished(out winnerBoardItem))
			{
				Console.Clear();
				
				// Mostra o tabuleiro.
				ShowBoard();

				// Obtém o próximo jogador.
				Player activePlayer = NextPlayer();

				Console.ForegroundColor = activePlayer.Color;
				Console.WriteLine("Jogador da vez: {0}", activePlayer.Name);

				while (true)
				{
					// Solicita a jogada.
					Console.Write("\nDigite a jogada: ");
					string play = Console.ReadLine();

					try
					{
						// Processa a jogada. Se o processamento funcionar, sai do loop.
						ProcessPlay(play, activePlayer);
						break;
					}
					catch (PlayException e)
					{
						// Em caso de exceção, mostra o erro e pede a jogada novamente.
						Console.WriteLine("Erro: {0}", e.Message);
					}
				}
			}

			// Ao chegar aqui, o jogo terminou.

			Console.Clear();

			// Mostra como o tabuleiro ficou após o jogo.
			ShowBoard();

			Console.WriteLine("O jogo terminou!\n");

			Player winnerPlayer = null;
			if (winnerBoardItem != null)
			{
				// Se winnerBoardItem não for null, alguém ganhou o jogo.
				if (players[0].BoardItem == winnerBoardItem)
				{
					// O jogador 1 ganhou o jogo.
					winnerPlayer = players[0];
				}
				else
				{
					// O jogador 2 ganhou o jogo.
					winnerPlayer = players[1];
				}

				Console.WriteLine("O vencedor é o jogador {0}! Parabéns!", winnerPlayer.Name);
			}
			else
			{
				// Se winnerBoardItem for null, ninguém ganhou.
				Console.WriteLine("Não houve um vencedor desta vez!");
			}
		}

		/// <summary>
		/// Lê os nomes dos jogadores.
		/// </summary>
		private void ReadPlayerNames()
		{
			string player1Name;
			while (true)
			{
				// Solicita o nome do jogador.
				Console.Write("Nome do Jogador 1: ");
				player1Name = Console.ReadLine();

				if (string.IsNullOrWhiteSpace(player1Name))
				{
					// Se for vazio, solicita novamente.
					Console.WriteLine("O nome do jogador 1 é inválido\n");
				}
				else
				{
					// O nome é válido.
					break;
				}
			}

			string player2Name;
			while (true)
			{
				// Solicita o nome do jogador.
				Console.Write("Nome do Jogador 2: ");
				player2Name = Console.ReadLine();

				if (string.IsNullOrWhiteSpace(player2Name))
				{
					// Se for vazio, solicita novamente.
					Console.WriteLine("O nome do jogador 2 é inválido\n");
				}
				else if (player1Name.ToUpper() == player2Name.ToUpper())
				{
					// Se for igual ao nome do primeiro jogador, solicita novamente.
					Console.WriteLine("Os jogadores não podem ter o mesmo nome\n");
				}
				else
				{
					// O nome é válido.
					break;
				}
			}

			// Cria os jogadores.
			players[0] = new Player(player1Name, ConsoleColor.Green, BoardItem.X);
			players[1] = new Player(player2Name, ConsoleColor.Red, BoardItem.O);
		}
		
		/// <summary>
		/// Mostra o tabuleiro.
		/// </summary>
		private void ShowBoard()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(board.GetFormattedBoard());
		}

		/// <summary>
		/// Muda para o próximo jogador.
		/// </summary>
		/// <returns>Próximo jogador.</returns>
		private Player NextPlayer()
		{
			// Lê o próximo índice como se a lista fosse circular.
			activePlayerIndex = (activePlayerIndex + 1) % 2;
			
			// Retorna o jogador associado ao novo índice.
			return players[activePlayerIndex];
		}

		/// <summary>
		/// Processa a jogada feita pelo jogador.
		/// </summary>
		/// <param name="play">Jogada.</param>
		/// <param name="player">Jogador.</param>
		private void ProcessPlay(string play, Player player)
		{
			int row;
			int col;

			try
			{
				// Faz o parse da jogada. Se o parse não funcionar, lança exceção.
				if (!int.TryParse(play.Substring(0, 1), out row) || !int.TryParse(play.Substring(1, 1), out col))
				{
					throw new PlayException("A jogada fornecida é inválida");
				}

				// Verifica se a linha e a coluna estão entre 0 e 2.
				if (row < 0 || row > 2 || col < 0 || col > 2)
				{
					throw new PlayException("Os índices utilizados estão fora do intervalo permitido");
				}

				// Efetua a jogada.
				player.Play(board, row, col);
			}
			catch (ArgumentOutOfRangeException e)
			{
				// Lança a exceção se ocorrer algum erro de Substring().
				throw new PlayException("A jogada fornecida é inválida", e);
			}
		}
	}
}