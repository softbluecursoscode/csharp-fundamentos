using System;

namespace ClasseArray
{
	class Program
	{
		static void Main()
		{
			int[] numeros = { 3, 5, 7, 9 };

			Array a = (Array)numeros;
			int i = (int)a.GetValue(1);
			a.SetValue(8, 0);
			int[] n = (int[])a;
			
			Console.WriteLine(numeros[0]);
			Console.WriteLine(numeros[1]);
			Console.WriteLine(numeros[2]);
			Console.WriteLine(numeros[3]);

			Array a2 = Array.CreateInstance(typeof(string), 5);
			a2.SetValue("a", 0);
			string s = (string)a2.GetValue(0);
			string[] a3 = (string[])a2;
		}
	}
}
