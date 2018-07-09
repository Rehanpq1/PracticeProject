using DesignPatern;
using DesignPatern.AbstractFactory;
using DesignPatern.Factory;
using System;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Console.WriteLine("__________________________ SingleTon with Thread Lock__________________________");
			///SingleTon with Thread Lock use to preserve there should only one instance

			Parallel.Invoke(
			() => FirstThread(),
			() => SecondThread()
			);

			Console.WriteLine("__________________________ Simple SingleTon __________________________");

			SingleTon obj = SingleTon.GetInstance;
			obj.PrintDetails("First obj");

			SingleTon obj1 = SingleTon.GetInstance;
			obj.PrintDetails("Second obj");


			new Program().CallFactory();

			new Program().CallFactoryMethod();

			Console.ReadLine();
		}

		private static void SecondThread()
		{
			SingleTon obj = SingleTon.GetInstance;
			obj.PrintDetails("Thread Second obj");
		}

		private static void FirstThread()
		{
			SingleTon obj = SingleTon.GetInstance;
			obj.PrintDetails("Thread First obj");
		}


		private void CallFactory()
		{
			Console.WriteLine("___________________________Factory  _____________________________________");

			Console.WriteLine("Calling Factory  ");

			PrintDiscount(EnumProduct.Fashion);

			PrintDiscount(EnumProduct.Home);

			PrintDiscount(EnumProduct.Electronic);
		}

		void PrintDiscount(EnumProduct productEnum)
		{
			IProduct objProduct = new ProductFactory().GetProductType(productEnum);

			Console.WriteLine($" Discount on Fashion {productEnum.ToString()} {objProduct.GetDiscount()} \n Coupoun upto {objProduct.ApplyCoupoun()}\n\n");
		}


		private void CallFactoryMethod()
		{
			Console.WriteLine("___________________________Calling Abstract Factory Method _____________________________________");

			Console.WriteLine("Calling Abstract Factory Method ");

			PrintProductData(EnumProduct.Fashion);

			PrintProductData(EnumProduct.Electronic);
		}

		private void PrintProductData(EnumProduct productEnum)
		{
			var objBaseAbstract = new ProductAbstractFactoryMethod().CreateProduct(productEnum);
			var objProduct = objBaseAbstract.ApplyDiscount_Coupoun();

			Console.WriteLine($" Discount on {objProduct.Category} : {objProduct.Discount} \n" +
			   $" Coupoun on {objProduct.Category} : {objProduct.Couple} \n" +
			   $" Return allow on {objProduct.Category} : {objProduct.ReturnAllow} \n" +
			   $" Delivery charge on {objProduct.Category} : {objProduct.DeliveryCharge} \n" +
			   $" Product Id : {objProduct.Id} \n" );
		}
	}
}
