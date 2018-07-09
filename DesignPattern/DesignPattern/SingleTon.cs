using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	public class SingleTon
	{
		static int count = 0;
		private SingleTon()
		{
			count++;
		}
		private static SingleTon instance;
		public static SingleTon GetInstance
		{
			get
			{
				if (instance == null)
					instance = new SingleTon();
				return instance;
			}
		}
		public void PrintDetails(string message)
		{
			Console.WriteLine(message);
			Console.WriteLine(count);
		}
	}
}
