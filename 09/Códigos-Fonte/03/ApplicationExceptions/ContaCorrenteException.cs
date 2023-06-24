using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationExceptions
{
	public class ContaCorrenteException : Exception
	{
		public ContaCorrenteException() { }
		public ContaCorrenteException(string message) : base(message) { }
		public ContaCorrenteException(string message, Exception inner) : base(message, inner) { }
	}
}
