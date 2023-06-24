using System;
using System.Globalization;
using System.Threading;

namespace Exercicio_1_Mod_5
{
    class Program
    {
        static void Main()
        {
            CultureInfo ci = new CultureInfo("en-US");

            int operacao = 0;
            do
            {
                Console.WriteLine("Calcular área: 1 - Triângulo / 2 - Quadrado / 3 - Circunferencia / 4 - Trapezio");
                operacao = int.Parse(Console.ReadLine());

                if (operacao == 1)
                {
                    Triangulo t = new Triangulo();
                    Console.WriteLine("Calcular a área do triângulo");
                    Console.WriteLine("Informe a base: ");
                    t.b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura: ");
                    t.h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Área =" + Convert.ToString(t.CalcularArea(), ci));
                }

                else if (operacao == 2)
                {
                    Quadrado q = new Quadrado();
                    Console.WriteLine("Calcular a área do quadrado");
                    Console.WriteLine("Informe o lado: ");
                    q.l = double.Parse(Console.ReadLine());
                    Console.WriteLine("Área =" + q.CalcularArea());
                }

                else if (operacao == 3)
                {
                    Circunferencia c = new Circunferencia();
                    Console.WriteLine("Calcular a circunferência");
                    Console.WriteLine("Informe o raio: ");
                    c.r = double.Parse(Console.ReadLine());
                    Console.WriteLine("Circunferência = " + c.CalcularArea());
                }

                else if (operacao == 4)
                {
                    Trapezio tp = new Trapezio();
                    Console.WriteLine("Calcular a área do trapézio");
                    Console.WriteLine("Informe a base maior: ");
                    tp.B = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a base menor: ");
                    tp.b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura: ");
                    tp.h = double.Parse(Console.ReadLine());
                    Console.WriteLine(tp.CalcularArea());
                }
            } while (operacao == 1 || operacao == 2 || operacao == 3 || operacao == 4);


        }
    }

    class Triangulo
    {
        public double b;
        public double h;
        public double CalcularArea()
        {
            double A = b * h / 2;
            return A;
        }
    }

    class Quadrado
    {
        public double l;
        public double CalcularArea()
        {
            double A = l * l;
            return A;
        }
    }

    class Circunferencia
    {
        public double r, PI = Math.PI;
        public double CalcularArea()
        {
            double A = PI * (r * r);
            return A;
        }
    }

    class Trapezio
    {
        public double B;
        public double b;
        public double h;
        public double CalcularArea()
        {
            double A = ((B + b) / 2) * h;
            return A;
        }

    }
}