using System;

namespace Softblue
{
	// Estrutura que representa um triângulo.
	struct Triangulo<T>
	{
		// Pontos do triângulo.
		public Ponto<T> P1 { get; set; }
		public Ponto<T> P2 { get; set; }
		public Ponto<T> P3 { get; set; }

        public Triangulo(Ponto<T> p1, Ponto<T> p2, Ponto<T> p3) : this()
        {
            this.DefinirPontos(p1, p2, p3);
        }

		// Método que permite definir pontos para o triângulo.
		public void DefinirPontos(Ponto<T> p1, Ponto<T> p2, Ponto<T> p3)
		{
			this.P1 = p1;
			this.P2 = p2;
			this.P3 = p3;
		}

		// Método que permite definir pontos para o triângulo.
		public void DefinirPontos(T x1, T y1, T z1, T x2, T y2, T z2, T x3, T y3, T z3)
		{
			// Chama a outra implementação de DefinirPontos().
			DefinirPontos(new Ponto<T>(x1, y1, z1), new Ponto<T>(x2, y2, z2), new Ponto<T>(x3, y3, z3));
		}

		// Sobrescrita de ToString().
		public override string ToString()
		{
			return string.Format("p1 => [{0}]\np2 => [{1}]\np3 => [{2}]", P1, P2, P3);
		}
	}

	// Estrutura que representa um ponto
	struct Ponto<T>
	{
		// Coordenadas do ponto.
		public T X { get; set; }
		public T Y { get; set; }
		public T Z { get; set; }

		// Construtor que recebe as coordenadas.
		public Ponto(T x, T y, T z) : this()
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		// Sobrescrita de ToString().
		public override string ToString()
		{
			return string.Format("x = {0}, y = {1}, z = {2}", X, Y, Z);
		}
	}
}
