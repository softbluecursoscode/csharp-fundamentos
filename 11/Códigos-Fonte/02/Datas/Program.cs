using System;

namespace Datas
{
	class Program
	{
		static void Main()
		{
			DateTime d = new DateTime(1970, 10, 2);
			Console.WriteLine(d);

			DayOfWeek dow = d.DayOfWeek;
			Console.WriteLine(dow);

			DateTime d2 = DateTime.Now;
			DateTime d3 = DateTime.Today;

			DateTime d4 = d.AddMonths(-5);
			Console.WriteLine(d4);

			TimeSpan ts = new TimeSpan(3, 25, 10);
			DateTime d5 = new DateTime(1980, 2, 3, 10, 0, 0);

			DateTime d6 = d5.Add(ts);
			Console.WriteLine(d6);
			DateTime d7 = d5.Subtract(ts);
			Console.WriteLine(d7);
		}
	}
}
