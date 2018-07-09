using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
	public interface IService
	{
		void Serve();
	}

	public class Service : IService
	{
		public void Serve()
		{
			Console.WriteLine("Service Called............");
			//To Do: Some Stuff
		}
	}

	public class Client
	{

		public Client()
		{
		}
 
		private IService _service;
		/// <summary>
		/// Constructor Dependency Injection
		/// </summary>
		/// <param name="service"></param>
		public Client(IService service)
		{
			Console.WriteLine("Constructor Dependency Service Started");
			this._service = service;
		}

		/// <summary>
		/// Property Dependency Injection
		/// </summary>
		public IService Service
		{
			set { this._service = value; }
		}


		/// <summary>
		/// Method Dependency Injection
		/// </summary>
		public void Start(IService service)
		{
			this._service = service;
			Console.WriteLine("Method Dependency Service Started");
			this._service.Serve();
			//To Do: Some Stuff
		}

		public void Start()
		{
			Console.WriteLine("Service Started");
			this._service.Serve();
			//To Do: Some Stuff
		}
	}
}
