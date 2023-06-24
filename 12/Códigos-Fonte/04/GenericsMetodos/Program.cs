using System;

namespace GenericsMetodos
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = Creator.Create<int>();
		}
	}

	public class Creator
	{
		public static T Create<T>() where T : new()
		{
			return new T();
		}
	}
}
