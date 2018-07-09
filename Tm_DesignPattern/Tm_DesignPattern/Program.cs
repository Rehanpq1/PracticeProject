using System;

namespace Tm_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Log objLog = Log.GetInstance;            
            objLog.PrintLog();

            var nestedObj = new Log.GeneralLog();

            Log objLog2 = Log.GetInstance;
            objLog2.PrintLog();

            
        }
    }
}
