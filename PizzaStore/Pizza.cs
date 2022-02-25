using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Pizza
    {
        public string _pizzaType;
        public int _price;
        

        public Pizza(string pizzaType, int price)
        {
            _pizzaType = pizzaType;
            _price = price;

        }
        public string PizzaType
        {
            get { return _pizzaType; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        }
}
