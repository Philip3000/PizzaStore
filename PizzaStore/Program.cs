using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to continue");
            Account ac1 = new Account("Jens", "Peter", "+45 91871747", "sørenpeter@gmail.com", "maglegårdsvej", "2tv");
            ac1.GetDeliveryInfo();
            Console.ReadKey();
        }
    }
}
