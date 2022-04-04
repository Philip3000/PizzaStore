using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore;

namespace PizzaStore
{
    
    public static class UserDialog 
    {
        public static List<Pizza> menuItems = new List<Pizza>();

        static Pizza GetMenuCatalog()
        {
            Pizza pizza1 = new Pizza(0, "", 0);
            

            //MenuCatalog menuItem = new MenuCatalog();
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("|   Creating Pizza   |");
            Console.WriteLine("----------------------");
            Console.Write("Enter PizzaType: ");
            pizza1.PizzaType = Console.ReadLine();

            Console.Write("Enter Id: ");
            try
            {
                string input = Console.ReadLine();
                pizza1.PizzaId = Int32.Parse(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to enter id, remember to use numbers!");
                Console.ReadLine();
            }
            Console.Write("Enter Price: ");
            try
            {
                string input = Console.ReadLine();
                pizza1.Price = Int32.Parse(input);
            }
            catch (Exception)
            { 
                Console.WriteLine("Unable to enter price, are you using letters or numbers?");
                Console.ReadKey();
                throw;
            }
            
            menuItems.Add(pizza1);
            menuItems.Sort();
            return pizza1;
        }
        
        static int MainMenu(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("|---------------|");
            Console.WriteLine("| Pizza Creator |");
            Console.WriteLine("|---------------|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press dedicated key to go to choice");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }
            String input = Console.ReadKey().KeyChar.ToString();
            try
            {
                int result = Int32.Parse(input);
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input, try again");
            }
            return -1;
        }
        static public void Run()
        {
            bool proceed = true;
            List<string> mainMenuChoice = new List<string>()
            {
                "0: Quit",
                "1: Create Pizza",
                "2: Remove Pizza From Menu",
                "3: Show Menu",
                "4: Find Pizza",
                "5: Update Pizza"
            };

            while (proceed)
            {
                int key = MainMenu(mainMenuChoice);
                Console.WriteLine();

                switch (key)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("Ending");
                        break;
                    case 1:
                        try
                        {
                            GetMenuCatalog();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Can't create pizza");

                        }
                        break;
                    case 2:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine($"You selected: {mainMenuChoice[key]}");
                            Console.WriteLine("------------------------------------------------");
                            Console.Write("Enter PizzaType for pizza you wish to delete from menu: ");
                            Console.WriteLine();
                            int A = 0;
                            foreach (Pizza p in menuItems)
                            {
                                Console.WriteLine($"{A}: ID: {p.PizzaType}");
                                A += 1;
                            }
                            string input = Console.ReadKey().KeyChar.ToString();
                            int num = Int32.Parse(input);
                            Pizza Pizza = menuItems[num];
                            menuItems.Remove(Pizza);

                            Console.WriteLine($" {Pizza} has been deleted");
                            Console.ReadKey();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error, try again");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        foreach (Pizza p in menuItems)
                        {
                            Console.WriteLine(p);
                        }
                        Console.WriteLine();
                        Console.WriteLine("There are no more Pizzas in the menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        try
                        {
                            int b = 0;
                            foreach (Pizza p in menuItems)
                            {
                                b++;
                            }
                            if (b >= 1)
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Which Pizza would you like to find?");
                                Console.WriteLine("Press the corresponding number for your Pizza");
                                Console.WriteLine();
                                int A = 0;
                                foreach (Pizza p in menuItems)
                                {
                                    Console.WriteLine($"{A}: ID: {p.PizzaType}");
                                    A += 1;
                                }
                                string input = Console.ReadKey().KeyChar.ToString();
                                int num = Int32.Parse(input);
                                Pizza Pizza = menuItems[num];
                                Console.Clear();
                                Console.WriteLine($" {Pizza}");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Please create a pizza first");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to go to Pizza maker");
                                Console.ReadKey();
                                GetMenuCatalog();
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter number from index");
                        }
                        break;
                    case 5:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Which Pizza would you like to update?");
                            Console.WriteLine("Press the corresponding number for your Pizza");
                            Console.WriteLine();
                            int A = 0;
                            foreach (Pizza p in menuItems)
                            {
                                Console.WriteLine($"{A}: ID: {p.PizzaType}");
                                A += 1;
                            }
                            string input = Console.ReadKey().KeyChar.ToString();
                            int num = Int32.Parse(input);
                            Pizza Pizza = menuItems[num];
                            Console.Clear();
                            Console.WriteLine($" {Pizza}");

                            Console.WriteLine("New Name:");
                            Pizza.PizzaType = Console.ReadLine().ToString();

                            Console.WriteLine("New Price:");
                            string input2 = Console.ReadLine();
                            Pizza.Price = Int32.Parse(input2);

                            Console.WriteLine("New ID:");
                            string input3 = Console.ReadLine();
                            Pizza.PizzaId = Int32.Parse(input3);                        
                        } 
                        catch (Exception)
                        {

                        }
                        break;
                    default:
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
