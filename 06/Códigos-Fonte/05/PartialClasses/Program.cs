using System;

namespace PartialClasses
{
	class Program
	{
		static void Main()
		{
			QuartoHotel q = new QuartoHotel();
			q.Numero = 102;
			q.Andar = 1;
			q.Fumante = false;
			q.Reservar();
			q.CancelarReserva();
		}
	}
}
