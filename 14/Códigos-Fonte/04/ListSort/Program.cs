using System;
using System.Collections.Generic;

namespace ListSort
{
	class Program
	{
		static void Main()
		{
			List<Tarefa> tarefas = new List<Tarefa>();

			tarefas.Add(new Tarefa() { Descricao = "Lavar louça", Prioridade = Tarefa.Nivel.BAIXA });
			tarefas.Add(new Tarefa() { Descricao = "Limpar chão", Prioridade = Tarefa.Nivel.MEDIA });
			tarefas.Add(new Tarefa() { Descricao = "Fazer compras", Prioridade = Tarefa.Nivel.MEDIA });
			tarefas.Add(new Tarefa() { Descricao = "Lavar roupa", Prioridade = Tarefa.Nivel.ALTA });
			tarefas.Add(new Tarefa() { Descricao = "Varrer calçada", Prioridade = Tarefa.Nivel.BAIXA });

			//tarefas.Sort();

			ComparadorAlfabetico c = new ComparadorAlfabetico();
			tarefas.Sort(c);

			foreach (Tarefa tarefa in tarefas)
			{
				Console.WriteLine(tarefa);
			}
		}
	}

	public class Tarefa : IComparable<Tarefa>
	{
		public enum Nivel
		{
			ALTA = 10,
			MEDIA = 5,
			BAIXA = 0
		}

		public string Descricao { get; set; }
		public Nivel Prioridade { get; set; }

		public override string ToString()
		{
			return string.Format("{0} ({1})", Descricao, Prioridade);
		}

		public int CompareTo(Tarefa other)
		{
			int c = this.Prioridade.CompareTo(other.Prioridade);

			if (c == 0)
			{
				return this.Descricao.CompareTo(other.Descricao);
			}

			return -c;
		}
	}

	public class ComparadorAlfabetico : IComparer<Tarefa>
	{
		public int Compare(Tarefa x, Tarefa y)
		{
			return x.Descricao.CompareTo(y.Descricao);
		}
	}
}
