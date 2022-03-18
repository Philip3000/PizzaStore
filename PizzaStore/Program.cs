using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore Code = new PizzaStore();
            Code.Start();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            
        }
    }
}
