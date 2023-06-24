using System;

namespace ObjectInitializer
{
	class Program
	{
		static void Main()
		{
			Contato c = new Contato() { Nome = "José Silva", Telefone = "7837-2974", Email = "jose@email.com", Endereco = "R. dos Limões, 320" };
			//c.Nome = "José Silva";
			//c.Telefone = "7837-2974";
			//c.Email = "jose@email.com";
			//c.Endereco = "R. dos Limões, 320";
			c.MostrarInfo();

			Contato c2 = new Contato("José Silva") { Telefone = "7837-2974", Email = "jose@email.com", Endereco = "R. dos Limões, 320" };
			c2.MostrarInfo();
		}
	}

	public class Contato
	{
		public string Nome { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public string Endereco { get; set; }

		public Contato()
		{
			Console.WriteLine("Contato()");
		}

		public Contato(string nome)
		{
			Console.WriteLine("Contato(string)");
			this.Nome = nome;
		}

		public void MostrarInfo()
		{
			Console.WriteLine("Nome: " + Nome);
			Console.WriteLine("Telefone: " + Telefone);
			Console.WriteLine("E-mail: " + Email);
			Console.WriteLine("Endereço: " + Endereco);
		}
	}
}
