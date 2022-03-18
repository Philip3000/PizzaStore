using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class PizzaStore
    {
        public void Start()
        {

            Pizza pizza1 = new Pizza("Magharita", 54);
            Pizza pizza2 = new Pizza("Vesuvio", 60);
            Pizza pizza3 = new Pizza("Hawaii", 65);

            Customer customer1 = new Customer("Christian Eriksen", "Bryggeren 12", "49582074");
            Customer customer2 = new Customer("Christian Eriksen", "Bryggeren 18", "83710572");
            Customer customer3 = new Customer("Christian Eriksen", "Bryggeren 22", "57621987");

            Order order1 = new Order(pizza1, customer1);
            Order order2 = new Order(pizza2, customer2);
            Order order3 = new Order(pizza3, customer3);

            order1.NewOrder();
            Console.WriteLine($"New Order! Info: {order1}");
            order2.NewOrder();
            Console.WriteLine($"New Order! Info: {order2}");
            order3.NewOrder();
            Console.WriteLine($"New Order! Info: {order3}");



        }
    }
}
