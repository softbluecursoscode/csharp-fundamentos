using System;
using System.Collections.Generic;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Cria alguns produtos
			Produto p1 = new Produto("Laranja", 2.5);
			Produto p2 = new Produto("Laranja", 2.7);
			Produto p3 = new Produto("Maçã", 1.45);
			Produto p4 = new Produto("Mamão", 4.95);
			Produto p5 = new Produto("Limão", 2.3);

			// Cria um objeto Produtos indicando que os produtos devem ser armazenados num ArrayList. Um 
			// ArrayList mantém a ordem de inserção e aceita elementos duplicados.
			Produtos produtos = new Produtos(new List<Produto>());

			// Adiciona os produtos e imprime
			produtos.Adicionar(p1);
			produtos.Adicionar(p2);
			produtos.Adicionar(p3);
			produtos.Adicionar(p4);
			produtos.Adicionar(p5);
			produtos.ImprimirProdutos();

			// Muda para HashSet. Perceba que agora os produtos não terão ordem definida (vai depender do 
			// código hash gerado), mas os produtos duplicados serão removidos.
			produtos.MudarColecao(new HashSet<Produto>());
			produtos.ImprimirProdutos();

			// Muda para SortedSet. Perceba que agora os produtos serão ordenados por valor, 
			// já que é o que foi especificado no método compareTo(). Como é um Set, os elementos duplicados
			// continuam não existindo
			produtos.MudarColecao(new SortedSet<Produto>());
			produtos.ImprimirProdutos();
		}
	}

	// Classe que representa um produto. Implementa a interface IComparable<T>, então objetos desta classe
	// podem ser ordenados. Implementa também IEquatable<T>
	class Produto : IComparable<Produto>, IEquatable<Produto>
	{
		// Nome do produto
		private string nome;

		// Valor do produto
		private double valor;

		// Construtor, recebe um nome e valor do produto
		public Produto(string nome, double valor)
		{
			this.nome = nome;
			this.valor = valor;
		}

		// Read-only property
		public string Nome
		{
			get { return nome; }
		}

		// Read-only property
		public double Valor
		{
			get { return valor; }
		}

		// A implementação do CompareTo() ordena os produtos por ordem crescente de valor.
		public int CompareTo(Produto p)
		{
			// Utiliza o método compareTo() de double, que já efetua a comparação dos números
			return this.Valor.CompareTo(p.Valor);
		}

		// O método ToString() formata o produto para impressão
		public override string ToString()
		{
			return string.Format("{0,-10} {1,7:C}", Nome, Valor);
		}

		/*
		 * Elementos que são inseridos em um Set normalmente devem implementar os métodos Equals() e 
		 * GetHashCode(). Eles definem o que são elementos iguais e diferentes.
		 * Neste caso, dois produtos iguais são os que tem o mesmo nome.
		 */
		public override int GetHashCode()
		{
			return Nome.GetHashCode();
		}

		public override bool Equals(Object obj)
		{
			return Equals(obj as Produto);
		}

		public bool Equals(Produto other)
		{
			return this.Nome == other.Nome;
		}
	}

	// Esta classe representa uma coleção de produtos
	class Produtos
	{
		// Coleção de produtos. É referenciado por uma ICollection para permitir que o tipo de coleção
		// onde os produtos são armazenados varie
		public ICollection<Produto> produtos;

		// Construtor de produtos. Recebe uma coleção (preferencialmente vazia)
		public Produtos(ICollection<Produto> produtos)
		{
			this.produtos = produtos;
		}

		// Muda o tipo de coleção dos produtos adicionados. Basta fornecer uma nova coleção (vazia) e os 
		// produtos da coleção antiga são copiados para a nova
		public void MudarColecao(ICollection<Produto> produtos)
		{
			ICollection<Produto> temp = this.produtos;
			this.produtos = produtos;

			// Adiciona todos os elementos de uma coleção em outra coleção
			foreach (Produto p in temp)
			{
				this.produtos.Add(p);
			}
		}

		// Adiciona um produto à coleção
		public void Adicionar(Produto produto)
		{
			produtos.Add(produto);
		}

		// Imprime os produtos da coleção
		public void ImprimirProdutos()
		{
			// A linha abaixo mostra o nome da classe da coleção onde os produtos estão armazenados
			Console.WriteLine("Produtos armazenados em: " + produtos.GetType().Name);

			foreach (Produto p in produtos)
			{
				Console.WriteLine(p);
			}
			Console.WriteLine("---------------------------------------------------");
		}
	}
}