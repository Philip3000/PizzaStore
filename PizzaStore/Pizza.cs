using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Pizza 
    {
        #region Instance Fields
        private string _pizzaType;
        private int _price;
        private string _pizzaTopping;
        private int _toppingPrice;
        private int _pizzaId;

        #endregion

        #region Constructor
        public Pizza(int PizzaId, string PizzaType, int Price)
        {
            _pizzaId = PizzaId;
            _pizzaType = PizzaType;
            _price = Price;
            _toppingPrice = ToppingPrice;
            _pizzaTopping = PizzaTopping;
        }
            
        #endregion

        #region Properties
        public string PizzaType { get; set; }

        public int Price { get; set; }
        public string PizzaTopping { get; set; }

        public int ToppingPrice { get; set;}
        
        public int PizzaId { get; set; }

        #endregion

        #region Methods
        public void addToppingAndPrint(string PizzaTopping, int ToppingPrice)
        {
            Console.WriteLine($"Extra Topping: {PizzaTopping}");
        }

        public override string ToString()
        {
            return $"Pizza: {PizzaType} - ID: {PizzaId} Price: {Price + ToppingPrice}";
        }
        public void DeletePizza()
        {
            List<Pizza> pizzas = new List<Pizza>();
            string input = Console.ReadLine().ToString();
            Pizza pizza = new Pizza(0, "", 0);

            if (input == _pizzaType)
            {
                pizzas.Remove(new Pizza(0, input, 0));
            }
        }
        
        #endregion

    }
}
