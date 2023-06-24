using System;
using System.IO;

namespace FileStreams
{
	class Program
	{
		static void Main()
		{
			//FileStream fs = new FileStream(@"C:\Curso\arq.txt", FileMode.Create, FileAccess.Write);

			FileInfo fi = new FileInfo(@"C:\Curso\arq.txt");
			//FileStream fs = fi.Create();
			//FileStream fs = fi.OpenWrite();

			using (FileStream fs = fi.Open(FileMode.Append, FileAccess.Write))
			{
				fs.WriteByte((byte)'a');
				fs.WriteByte((byte)'b');
				fs.WriteByte((byte)'c');
			}

			using (FileStream fs = fi.Open(FileMode.Open, FileAccess.Read))
			{
				while (fs.Position < fs.Length)
				{
					char c = (char)fs.ReadByte();
					Console.WriteLine(c);
				}
			}

			FileInfo fiSource = new FileInfo(@"C:\Curso\logo.pdf");
			FileInfo fiTarget = new FileInfo(@"C:\Curso\logo2.pdf");

			using (FileStream fsSource = fiSource.OpenRead(), fsTarget = fiTarget.OpenWrite())
			{
				byte[] buffer = new byte[1024];

				while (true)
				{
					int bytesRead = fsSource.Read(buffer, 0, buffer.Length);

					if (bytesRead == 0)
					{
						break;
					}

					fsTarget.Write(buffer, 0, bytesRead);
				}
			}
		}
	}
}
