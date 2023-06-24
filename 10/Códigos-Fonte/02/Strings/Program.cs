using System;

namespace Strings
{
	class Program
	{
		static void Main()
		{
			{
				string s = "abc";
				string s2 = s.ToUpper();
				Console.WriteLine(s2);
			}
			{
				string s = "a";
				string s2 = "b";
				string s3 = s + s2;
				Console.WriteLine(s3);
			}
			{
				string s = "a\tb\tc\nd";
				Console.WriteLine(s);
				string s2 = "\"\\\"";
				Console.WriteLine(s2);
			}
			{
				string s = @"C:\Softblue\CursoC#\arquivo";
				Console.WriteLine(s);
			}
		}
	}
}
