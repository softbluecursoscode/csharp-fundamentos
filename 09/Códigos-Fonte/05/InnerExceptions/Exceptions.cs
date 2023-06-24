using System;

namespace InnerExceptions
{
	public class DivisaoException : Exception
	{
		public DivisaoException() { }
		public DivisaoException(string message) : base(message) { }
		public DivisaoException(string message, Exception inner) : base(message, inner) { }
	}

	public class CalculoException : Exception
	{
		public CalculoException() { }
		public CalculoException(string message) : base(message) { }
		public CalculoException(string message, Exception inner) : base(message, inner) { }
	}
}
