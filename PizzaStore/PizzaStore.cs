using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class PizzaStore
    {
        public void Start()
        {

          
            List<Customer> Customers = new List<Customer>();
            Customer customer1 = new Customer("Christian Eriksen", "Bryggeren 12", "49582074");
            Customer customer2 = new Customer("Henrik Dahl", "Bryggeren 18", "83710572");
            Customer customer3 = new Customer("Casper Petersen", "Bryggeren 22", "57621987");
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Customers.Remove(customer1);

            foreach (Customer c in Customers) {
                Console.WriteLine(c);
            }
           
    



        }
    }
}
