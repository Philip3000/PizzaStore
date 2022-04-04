using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Order
    {
        #region Instance Field
        private double _tax;
        private double _totalPrice;
        private int _deliverycosts;
        private static int _orderNr;
        Pizza pizza1;
        #endregion

        #region Constructor
        public Order(Pizza pizza, Customer customer)
        {
            pizza1 = new Pizza(0, "", 0);
            pizza1 = pizza;
            _tax = 2.5;
            DeliveryCosts = 40;
            _orderNr = NewOrder();
        }
        #endregion

        #region Properties
        public double Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        public int DeliveryCosts
        {
            get { return _deliverycosts; }
            set { _deliverycosts = value; }
        }
        public static int OrderNr
        {
            get { return _orderNr; }
            set { _orderNr = value; }
        }
        #endregion

        #region Methods
        public double CalculateTotalPrice()
        {
            return pizza1.Price + (1 + Tax /100) + DeliveryCosts + pizza1.ToppingPrice;
        }
        public override string ToString()
        {
            return $"Pizza: {pizza1.PizzaType} - Tax: {Tax}% - Delivery: {DeliveryCosts} - Total: {CalculateTotalPrice()} OrderNr: {OrderNr}";
        }
        public int NewOrder()
        {
            return _orderNr = _orderNr + 1;
        }
        #endregion
    }
}
