using System;

namespace DependencyInjection
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			///Constructor Injection
			Client client = new Client(new Service());
			client.Start();

			///Property Injection
			Client propertyInjection = new Client();
			propertyInjection.Service = new Service();
			propertyInjection.Start();


			/// Method Dependency Injection
			Client MethodInjection = new Client();
			MethodInjection.Start(new Service());

			Console.ReadKey();
		}
	}
}
