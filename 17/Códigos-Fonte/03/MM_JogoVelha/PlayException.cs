using System;

namespace Softblue
{
	/// <summary>
	/// Exceção lançada quando ocorre algum problema na jogada feita pelo jogador.
	/// </summary>
	public class PlayException : Exception
	{
		/// <summary>
		/// Construtor.
		/// </summary>
		public PlayException() { }
		
		/// <summary>
		/// Construtor.
		/// </summary>
		/// <param name="message">Mensagem da exceção.</param>
		public PlayException(string message) : base(message) { }

		/// <summary>
		/// Construtor.
		/// </summary>
		/// <param name="message">Mensagem da exceção.</param>
		/// <param name="inner">Exceção aninhada.</param>
		public PlayException(string message, Exception inner) : base(message, inner) { }		
	}
}
