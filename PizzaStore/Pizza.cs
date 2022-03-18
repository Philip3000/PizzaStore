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
        #endregion 

        #region Constructor
        public Pizza(string pizzaType, int price)
        {
            _pizzaType = pizzaType;
            _price = price;
            _pizzaTopping = "";
            _toppingPrice = 0;
        }
        #endregion 

        #region Properties
        public string PizzaType
        {
            get { return _pizzaType; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string PizzaTopping
        {
            get { return _pizzaTopping; }
            set { _pizzaTopping = value; }
        }
        public int ToppingPrice
        {
            get { return _toppingPrice; }
            set { _toppingPrice = value; }
        }
        #endregion

        #region Methods
        public void addAndPrint(string PizzaTopping, int ToppingPrice)
        {
            Console.WriteLine($"Extra Topping: {PizzaTopping}");
        }

        public override string ToString()
        {
            return $"Pizza: {PizzaType} - Topping: {PizzaTopping} Price: {Price + ToppingPrice}";
        }
        #endregion

    }
}
