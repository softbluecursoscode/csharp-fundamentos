using System;
using System.IO;

namespace StreamReaderWriter
{
	class Program
	{
		static void Main()
		{
			//FileStream fs = new FileStream(@"C:\Curso\texto.txt", FileMode.Create, FileAccess.Write);
			//StreamWriter sw = new StreamWriter(fs);

			FileInfo fi = new FileInfo(@"C:\Curso\texto.txt");
			StreamWriter sw = fi.CreateText();
			sw.Write("Olá, este é um texto de exemplo.\n");
			sw.Close();

			StreamReader sr = fi.OpenText();

			string line;
			while ((line = sr.ReadLine()) != null)
			{
				Console.WriteLine(line);
			}

			//string conteudo = sr.ReadToEnd();
			//Console.WriteLine(conteudo);

			sr.Close();
		}
	}
}
