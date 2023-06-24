using System;

namespace Casting
{
	class Program
	{
		static void Main()
		{

			// Casting implícito
			int i = 10;
			double d = i;
			
			// Casting implícito
			short s = 5;
			long l = s;

			// Casting explícito
			double d2 = 3.5;
			int i2 = (int)d2;

			// Casting explícito
			long l2 = 25;
			int i3 = (int)l2;

			// Casting explícito
			long l3 = 438746387462735;
			int i4 = (int)l3; // Resultado negativo!
		}
	}
}
