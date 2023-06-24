using System;

namespace Generics
{
	public class Lista<T>
	{
		private No<T> primeiro;

		public void Adicionar(T elemento)
		{
			No<T> novoNo = new No<T>();
			novoNo.Elemento = elemento;

			if (primeiro == null)
			{
				primeiro = novoNo;
			}
			else
			{
				No<T> no = primeiro;
				while (no.Proximo != null)
				{
					no = no.Proximo;
				}
				no.Proximo = novoNo;
			}
		}

		public T Ler(int pos)
		{
			if (pos < 0)
			{
				return default(T);
			}

			if (primeiro == null)
			{
				return default(T);
			}

			int count = 0;
			No<T> no = primeiro;

			while (count < pos)
			{
				no = no.Proximo;
				count++;
			}

			return no.Elemento;
		}

		private class No<T>
		{
			public T Elemento { get; set; }
			public No<T> Proximo { get; set; }
		}
	}
}
