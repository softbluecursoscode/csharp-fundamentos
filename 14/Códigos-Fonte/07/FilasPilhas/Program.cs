using System;
using System.Collections.Generic;

namespace FilasPilhas
{
	class Program
	{
		static void Main()
		{
			Queue<char> queue = new Queue<char>();
			//Stack<char> stack = new Stack<char>();

			while (true)
			{
				Console.Write("Elemento: ");
				string s = Console.ReadLine();

				if (String.IsNullOrWhiteSpace(s))
				{
					break;
				}

				char c = s[0];

				queue.Enqueue(c);
				//stack.Push(c);
			}

			while (true)
			{
				char c = queue.Dequeue();
				//char c = stack.Pop();

				Console.WriteLine("=> " + c);

				if (queue.Count == 0)
				//if (stack.Count == 0)
				{
					break;
				}
			}
		}
	}
}
