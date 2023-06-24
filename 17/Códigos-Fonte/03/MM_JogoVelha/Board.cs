using System;
using System.Text;

namespace Softblue
{
	/// <summary>
	/// Itens que podem fazer parte do tabuleiro.
	/// </summary>
	enum BoardItem
	{
		X,
		O,
		EMPTY // Representa o espaço vazio.
	}

	/// <summary>
	/// Tabuleiro do jogo da velha.
	/// </summary>
	class Board
	{
		/// <summary>
		/// Matriz do jogo.
		/// </summary>
		private BoardItem[,] matrix = new BoardItem[3, 3];

		/// <summary>
		/// Construtor.
		/// </summary>
		public Board()
		{
			// Inicializa as posições da matriz com EMPTY
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					matrix[i, j] = BoardItem.EMPTY;
				}
			}
		}

		/// <summary>
		/// Retorna o tabuleiro formatado.
		/// </summary>
		/// <returns>Tabuleiro formatado.</returns>
		public string GetFormattedBoard()
		{
			// Usa um StringBuilder para evitar a concatenação de strings.
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					// Converte um BoardItem para um char para mostrar na tela
					sb.Append(" ").Append(ConvertBoardItemToChar(matrix[i, j]));

					if (j < 2)
					{
						sb.Append(" | ");
					}
				}
				sb.AppendLine();

				if (i < 2)
				{
					sb.Append("------------").AppendLine();
				}
			}

			return sb.ToString();
		}

		/// <summary>
		/// Converte um BoardItem para um char.
		/// </summary>
		/// <param name="boardItem">BoardItem para converter.</param>
		/// <returns>Caractere resultante.</returns>
		private char ConvertBoardItemToChar(BoardItem boardItem)
		{
			switch (boardItem)
			{
				case BoardItem.X: return 'X';
				case BoardItem.O: return 'O';
				default: return ' ';
			}
		}

		/// <summary>
		/// Verifica se o jogo terminou.
		/// </summary>
		/// <param name="winnerBoardItem">Parâmetro de saída, que indica o BoardItem ganhador (se houver um).</param>
		/// <returns>True se o jogo terminou; false, caso contrário.</returns>
		public bool IsFinished(out BoardItem? winnerBoardItem)
		{
			// Verifica se existe alguma sequência de 3 itens.
			winnerBoardItem = CheckSequence();

			if (winnerBoardItem != null)
			{
				// Se houver uma sequência, o jogo terminou.
				// winnerBoardItem vai conter o item ganhador.
				return true;
			}

			// Se não houver sequência, verifica se o tabuleiro ainda pode receber jogadas.
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (matrix[i, j] == BoardItem.EMPTY)
					{
						return false;
					}
				}
			}

			return true;
		}

		/// <summary>
		/// Efetua uma jogada.
		/// </summary>
		/// <param name="row">Linha da jogada.</param>
		/// <param name="col">Coluna da jogada.</param>
		/// <param name="boardItem">Item da jogada.</param>
		public void Play(int row, int col, BoardItem boardItem)
		{
			if (matrix[row, col] != BoardItem.EMPTY)
			{
				// Se a jogada já foi realizada, lança exceção.
				throw new PlayException("Esta jogada já foi realizada");
			}

			// Atribui o item à posição do tabuleiro.
			matrix[row, col] = boardItem;
		}

		/// <summary>
		/// Verifica se existe uma sequência de 3 itens.
		/// </summary>
		/// <returns>O item que faz parte da sequência ou null se não existir sequência.</returns>
		private BoardItem? CheckSequence()
		{
			if (matrix[0, 0] != BoardItem.EMPTY && matrix[0, 0] == matrix[0, 1] && matrix[0, 1] == matrix[0, 2])
			{
				return matrix[0, 0];
			}

			if (matrix[1, 0] != BoardItem.EMPTY && matrix[1, 0] == matrix[1, 1] && matrix[1, 1] == matrix[1, 2])
			{
				return matrix[1, 0];
			}

			if (matrix[2, 0] != BoardItem.EMPTY && matrix[2, 0] == matrix[2, 1] && matrix[2, 1] == matrix[2, 2])
			{
				return matrix[2, 0];
			}

			if (matrix[0, 0] != BoardItem.EMPTY && matrix[0, 0] == matrix[1, 0] && matrix[1, 0] == matrix[2, 0])
			{
				return matrix[0, 0];
			}

			if (matrix[0, 1] != BoardItem.EMPTY && matrix[0, 1] == matrix[1, 1] && matrix[1, 1] == matrix[2, 1])
			{
				return matrix[0, 1];
			}

			if (matrix[0, 2] != BoardItem.EMPTY && matrix[0, 2] == matrix[1, 2] && matrix[1, 2] == matrix[2, 2])
			{
				return matrix[0, 2];
			}

			if (matrix[0, 0] != BoardItem.EMPTY && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
			{
				return matrix[0, 0];
			}

			if (matrix[0, 2] != BoardItem.EMPTY && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
			{
				return matrix[0, 2];
			}

			return null;
		}
	}
}
