using System;
using System.IO;

namespace Softblue
{
	class Program
	{
		// Constante para o arquivo que vai armazenar os dados
		private const string File = "livros.bin";

		static void Main()
		{
			// Exibe o menu de opções
			Console.WriteLine("Escolha uma opção:");
			Console.WriteLine("1 - Gravar dados");
			Console.WriteLine("2 - Ler dados");
			Console.Write("=> ");

			// Lê a opção digitada
			String opcao = Console.ReadLine();

			if (opcao == "1")
			{
				GravarDados();
			}
			else if (opcao == "2")
			{
				LerDados();
			}
			else
			{
				Console.WriteLine("Opção desconhecida");
			}
		}

		private static void LerDados()
		{
			// Cria dois objetos Livro
			Livro l1 = new Livro();
			Livro l2 = new Livro();

			// Inicia a stream para leitura de dados
			FileStream fs = new FileStream(File, FileMode.Open, FileAccess.Read);
			using (BinaryReader reader = new BinaryReader(fs))
			{
				l1.Read(reader);
				l2.Read(reader);
			}

			// Imprime os dados dos livros (o método ToString() será chamado)
			Console.WriteLine(l1);
			Console.WriteLine(l2);
		}

		private static void GravarDados()
		{
			// Cria os autores e livros a serem gravados no arquivo
			Autor a1 = new Autor();
			a1.Nome = "José Silva";
			a1.DataNascimento = DateTime.Parse("01/04/1972");

			Autor a2 = new Autor();
			a2.Nome = "Maria Oliveira";
			a2.DataNascimento = DateTime.Parse("25/02/1980");

			Livro l1 = new Livro();
			l1.Titulo = "Orientação a Objetos";
			l1.NumPaginas = 350;
			l1.Autor = a1;

			Livro l2 = new Livro();
			l2.Titulo = "Programação C#";
			l2.NumPaginas = 200;
			l2.Autor = a2;

			// Inicia a stream para gravação dos dados
			FileStream fs = new FileStream(File, FileMode.Create, FileAccess.Write);
			using (BinaryWriter writer = new BinaryWriter(fs))
			{
				l1.Write(writer);
				l2.Write(writer);
			}
		}
	}

	public class Autor : IRecordable
	{
		public String Nome { get; set; }

		// Usa um nullable type para permitir a atribuição de null
		public DateTime? DataNascimento { get; set; }

		public void Read(BinaryReader reader)
		{
			// Lê o nome do autor
			Nome = reader.ReadString();
			if (Nome == "<null>")
			{
				// Se a string "<null>" for retornada, significa que o autor não possuía nome quando foi gravado
				Nome = null;
			}

			// Lê a data de nascimento, em forma de um long (Int64)
			long time = reader.ReadInt64();
			if (time == -1)
			{
				// Caso -1 tenha sido gravado, a data de nascimento era nula
				DataNascimento = null;
			}
			else
			{
				// Cria o objeto DateTime com base no valor lido
				DataNascimento = new DateTime(time);
			}
		}

		public void Write(BinaryWriter writer)
		{
			// Grava o nome do autor
			if (Nome != null)
			{
				writer.Write(Nome);
			}
			else
			{
				// Se o nome for nulo, grava "<null>"
				writer.Write("<null>");
			}

			// Grava a data de nascimento
			if (DataNascimento != null)
			{
				writer.Write(DataNascimento.Value.Ticks);
			}
			else
			{
				// Se a data for nula, grava -1
				writer.Write((long)-1);
			}
		}

		public override string ToString()
		{
			return "Autor [nome=" + Nome + ", dataNascimento=" + DataNascimento + "]";
		}
	}

	public class Livro : IRecordable
	{
		public string Titulo { get; set; }
		public int NumPaginas { get; set; }
		public Autor Autor { get; set; }

		public void Read(BinaryReader reader)
		{
			// Lê o título do livro
			Titulo = reader.ReadString();
			if (Titulo == "<null>")
			{
				// Se o título for "<null>", ele era null quando foi gravado
				Titulo = null;
			}

			// Lê o número de páginas do livro
			NumPaginas = reader.ReadInt32();

			// Se o objeto autor for nulo, cria o objeto para que ele tenha seus dados populados
			if (Autor == null)
			{
				Autor = new Autor();
			}

			// Chama o método Read() do autor, que vai popular os dados do autor
			Autor.Read(reader);
		}

		public void Write(BinaryWriter writer)
		{
			// Grava o título
			if (Titulo == null)
			{
				// Se o título for nulo, grava "<null>"
				writer.Write("<null>");
			}
			else
			{
				writer.Write(Titulo);
			}

			// Grava o número de páginas
			writer.Write(NumPaginas);

			// Se houver um autor para o livro faz a gravação dos seus dados
			if (Autor != null)
			{
				Autor.Write(writer);
			}
		}

		public override string ToString()
		{
			return "Livro [titulo=" + Titulo + ", numPaginas=" + NumPaginas + ", autor=" + Autor + "]";
		}
	}

	public interface IRecordable
	{
		// Método para leitura dos dados
		void Read(BinaryReader reader);

		// Método para gravação dos dados
		void Write(BinaryWriter writer);
	}
}