using System;
using System.Collections.Generic;
using System.Text;

namespace Tm_DesignPattern
{
    public sealed class Log
    {
        static int countInstance = 0;
        static object obj = new object();
        private static Log Instance;
        public static Log GetInstance
        {
            get
            {

                if (Instance == null)
                {
                    Instance = new Log();
                   
                }
                return Instance;
            }
        }

        private Log()
        {
            countInstance++;
        }


        public void PrintLog()
        {
            Console.WriteLine("Printing Singlon Log");
            Console.WriteLine($"Instance Count: {countInstance}");
            Console.ReadLine();
        }

        public class GeneralLog 
        {
            Log obj = new Log();

            public GeneralLog()
            {
                var obj2 = obj;
            }

        }
    }
}
