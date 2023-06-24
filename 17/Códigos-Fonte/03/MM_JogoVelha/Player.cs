using System;

namespace Softblue
{
	/// <summary>
	/// Jogador do jogo.
	/// </summary>
	class Player
	{
		/// <summary>
		/// Nome do jogador.
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Cor que representa o jogador.
		/// </summary>
		public ConsoleColor Color { get; private set; }

		/// <summary>
		/// Item associado ao jogador ('X' ou 'O').
		/// </summary>
		public BoardItem BoardItem { get; private set; }

		/// <summary>
		/// Construtor.
		/// </summary>
		/// <param name="name">Nome do jogador.</param>
		/// <param name="color">Cor do jogador.</param>
		/// <param name="boardItem">Item do jogador.</param>
		public Player(string name, ConsoleColor color, BoardItem boardItem)
		{
			this.Name = name;
			this.Color = color;
			this.BoardItem = boardItem;
		}

		/// <summary>
		/// Executa uma jogada no tabuleiro.
		/// </summary>
		/// <param name="board">Tabuleiro.</param>
		/// <param name="row">Linha da jogada.</param>
		/// <param name="col">Coluna da jogada.</param>
		public void Play(Board board, int row, int col)
		{
			board.Play(row, col, BoardItem);
		}
	}
}
