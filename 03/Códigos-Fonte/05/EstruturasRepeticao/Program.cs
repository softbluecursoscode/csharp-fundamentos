using System;

namespace EstruturasRepeticao
{
	class Program
	{
		static void Main()
		{
			// Estrutura while
			{
				int x = 0;

				while (x <= 10)
				{
					Console.WriteLine(x);
					x++;
				}
			}

			// Estrutura do-while
			{
				int x = 0;

				do
				{
					Console.WriteLine(x);
					x++;
				}
				while (x <= 10);
			}

			// Estrutura for
			{
				for (int x = 0, y = 10; x <= 10; x++, y--)
				{
					Console.WriteLine(x);
					Console.WriteLine(y);
				}
			}

			// Uso de break e continue
			{
				for (int i = 1; i < 100; i++)
				{
					if (i % 2 == 0)
					{
						continue;
						//break;
					}

					Console.WriteLine(i);
				}
			}
		}
	}
}
