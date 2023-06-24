using System;


namespace Softblue
{
	class Program
	{
		static void Main()
		{
			// Chama o método NewInstance() para criar um objeto do tipo MessageService. Isto só é possível 
			// porque MessageService implementa a interface IService

			ServiceFactory<MessageService> factory = new ServiceFactory<MessageService>();
			MessageService service = factory.NewInstance();
			service.Execute();
		}
	}

	// Interface que representa um serviço hipotético
	public interface IService
	{
		//Método que executa o serviço. Deve ser implementado pelas classes que implementam esta interface
		void Execute();
	}

	// Classe utilizada na instanciação de objetos de serviço
	// As constraints definem que T deve implementar IService e ter um construtor padrão, sem parâmetros
	class ServiceFactory<T> where T : IService, new()
	{
		// Este método cria uma nova instância da classe T
		public T NewInstance()
		{
			return new T();
		}
	}

	// Serviço hipotético, que implementa IService
	public class MessageService : IService
	{
		public void Execute()
		{
			// Mostra uma mensagem
			Console.WriteLine("Serviço de mensagem");
		}
	}
}
