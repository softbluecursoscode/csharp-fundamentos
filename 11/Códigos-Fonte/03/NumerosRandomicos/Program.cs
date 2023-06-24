using System;

namespace NumerosRandomicos
{
	class Program
	{
		static void Main()
		{
			Random r = new Random();
			//Random r = new Random(200);

			for (int i = 0; i < 10; i++)
			{
				int n1 = r.Next();
				Console.WriteLine(n1);
				
				int n2 = r.Next(20);
				Console.WriteLine(n2);
				
				int n3 = r.Next(10, 30);
				Console.WriteLine(n3);
				
				double n4 = r.NextDouble();
				Console.WriteLine(n4);
			}
		}
	}
}
