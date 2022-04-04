using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class MenuCatalog 
    {
        Pizza pizza1 = new Pizza(0, "", 0);
        public static List<Pizza> menuItems = new List<Pizza>();

        public static void PrintMenu()
        {
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }
        }
        public void AddPizzaToMenu()
        {
            menuItems.Add(pizza1);
        }
        public void SearchPizza()
        {
            string input = Console.ReadKey().KeyChar.ToString();
            int num = Int32.Parse(input);
            Pizza Pizza = menuItems[num];
            Console.WriteLine(Pizza);
        }

        public void DeletePizza()
        {
            string input = Console.ReadKey().KeyChar.ToString();
            int num = Int32.Parse(input);
            Pizza pizzaToDelete = null;
            foreach (Pizza p in menuItems)
            {
                if (p.PizzaId == num)
                {
                    pizzaToDelete = p;
                }
                menuItems.Remove(pizzaToDelete);
            }

        }

        public void PrintPizza(int A)
        {
            foreach (Pizza p in menuItems)
                if (p.PizzaId == A)
                {
                    Console.WriteLine(p);
                }
        }
    }
}
