using System;
using System.IO;

namespace BinaryReaderWriter
{
	class Program
	{
		static void Main()
		{
			FileStream fs = new FileStream(@"C:\Curso\dados.bin", FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs);

			bw.Write(true);
			bw.Write(20);
			bw.Write(10.5);
			bw.Write("olá");

			bw.Close();

			fs = new FileStream(@"C:\Curso\dados.bin", FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			bool b = br.ReadBoolean();
			int i = br.ReadInt32();
			double d = br.ReadDouble();
			string s = br.ReadString();

			Console.WriteLine(b);
			Console.WriteLine(i);
			Console.WriteLine(d);
			Console.WriteLine(s);
		}
	}
}
