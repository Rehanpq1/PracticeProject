using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class SingleTonThread
    {
        static int count = 0;
        private SingleTonThread()
        {
            count++;
        }

        private static readonly object obj = new object();

        private static SingleTonThread instance;
        public static SingleTonThread Instance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                        instance = new SingleTonThread();
                    return instance;
                }
            }
        }

        public void PrintDetail(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine(count);
        }
    }
}
