using System;
using System.Text;

namespace GenericsConstraints
{
	class Program
	{
		static void Main()
		{
			//Creator<StringBuilder> c1 = new Creator<StringBuilder>();
			//StringBuilder sb = c1.Create();

			//Creator<int> c2 = new Creator<int>();
			//int s = c2.Create();

			Creator<MyClass> c3 = new Creator<MyClass>();
			MyClass mc = c3.Create();
		}
	}

	public class Creator<T> where T : class, IInitializable, new()
	{
		public T Create()
		{
			T obj = new T();
			obj.Init();
			return obj;
		}
	}

	public interface IInitializable
	{
		void Init();
	}

	public class MyClass : IInitializable
	{
		public void Init()
		{
			Console.WriteLine("Inicialização");
		}
	}

}
