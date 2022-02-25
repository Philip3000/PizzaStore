using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Customer
    {
        private string _name;
        private string _address;
        private string _phoneNumber;

        public Customer(string name, string address, string phoneNumber)
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
        }
        #region Properties
        public string Name
        {
            get { return _name; }
        }
        public string Address
        {
            get { return _address; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }
        #endregion
        #region methods
       
        #endregion 
    }
}
