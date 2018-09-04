using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1 testClass1 = new TestClass1();
            testClass1.Start();



            Console.WriteLine($"complete...");
            Console.WriteLine($"press any key to exit");

            Console.ReadKey();
        }
    }
}
