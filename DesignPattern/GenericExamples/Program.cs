using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericClass<string> generic = new GenericClass<string>();
            generic.AddItem("Rehan");
            generic.AddItem("Prasad");
            generic.AddItem("Sahil");
            generic.AddItem("Umesh");

            Console.WriteLine("Generic String");
            foreach(string str in generic.list)
            {
                Console.WriteLine($"String Value : {str}");
            }


            GenericClass<int> generic1 = new GenericClass<int>();
            generic1.AddItem(1);
            generic1.AddItem(2);
            generic1.AddItem(3);
            generic1.AddItem(4);

            Console.WriteLine("Generic Int");
            foreach (int i in generic1.list)
            {
                Console.WriteLine($"Int Value : {i}");
            }

            Console.ReadLine();
        }
    }
}
