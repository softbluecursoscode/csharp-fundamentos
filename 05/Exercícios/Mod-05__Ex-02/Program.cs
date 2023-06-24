using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Criação da turma
			Turma turma = new Turma();
		
			// Criação dos alunos
			Aluno aluno1 = new Aluno();
			Aluno aluno2 = new Aluno();
			Aluno aluno3 = new Aluno();
		
			// Associação entre os alunos e a turma
			turma.aluno1 = aluno1;
			turma.aluno2 = aluno2;
			turma.aluno3 = aluno3;
		
			// Cria as provas para cada aluno e define as notas
		
			Prova aluno1Prova1 = new Prova();
			aluno1Prova1.notaParte1 = 4.0;
			aluno1Prova1.notaParte2 = 2.5;
			aluno1.prova1 = aluno1Prova1;
		
			Prova aluno1Prova2 = new Prova();
			aluno1Prova2.notaParte1 = 1.0;
			aluno1Prova2.notaParte2 = 7.0;
			aluno1.prova2 = aluno1Prova2;
		
			Prova aluno2Prova1 = new Prova();
			aluno2Prova1.notaParte1 = 6.5;
			aluno2Prova1.notaParte2 = 3.5;
			aluno2.prova1 = aluno2Prova1;
		
			Prova aluno2Prova2 = new Prova();
			aluno2Prova2.notaParte1 = 0.0;
			aluno2Prova2.notaParte2 = 3.0;
			aluno2.prova2 = aluno2Prova2;
		
			Prova aluno3Prova1 = new Prova();
			aluno3Prova1.notaParte1 = 5.0;
			aluno3Prova1.notaParte2 = 4.0;
			aluno3.prova1 = aluno3Prova1;
		
			Prova aluno3Prova2 = new Prova();
			aluno3Prova2.notaParte1 = 6.0;
			aluno3Prova2.notaParte2 = 1.5;
			aluno3.prova2 = aluno3Prova2;
		
			// Imprime a média de cada aluno
			Console.WriteLine("Média Aluno 1: " + turma.aluno1.CalcularMedia());
			Console.WriteLine("Média Aluno 2: " + turma.aluno2.CalcularMedia());
			Console.WriteLine("Média Aluno 3: " + turma.aluno3.CalcularMedia());
		
			// Imprime a média da turma
			Console.WriteLine("Média Turma: " + turma.CalcularMedia());
		}
	}

	class Prova
	{
		// Notas das duas partes da prova
		public double notaParte1;
		public double notaParte2;

		public double CalcularNotaTotal()
		{
			// A nota total da prova é a soma das duas notas parciais
			return notaParte1 + notaParte2;
		}
	}

	class Aluno
	{
		// Provas realizadas pelo aluno
		public Prova prova1;
		public Prova prova2;

		public double CalcularMedia()
		{
			// Para calcular a média, utiliza a nota total de cada prova
			double media = prova1.CalcularNotaTotal() + prova2.CalcularNotaTotal();
			return media / 2;
		}
	}

	class Turma
	{
		// Alunos da turma
		public Aluno aluno1;
		public Aluno aluno2;
		public Aluno aluno3;

		public double CalcularMedia()
		{
			// Para calcular a média da turma, utiliza a média de cada aluno
			double media = aluno1.CalcularMedia() + aluno2.CalcularMedia() + aluno3.CalcularMedia();
			return media / 3;
		}
	}
}
