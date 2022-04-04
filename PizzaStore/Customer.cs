using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Customer
    {
        #region Instance Fields
        private string _name;
        private string _address;
        private string _phoneNumber;
        //Customer customer = new Customer("", "", "");
        List<Customer> AllCustomers = new List<Customer>();
        #endregion

        #region Constructor
        public Customer(string name, string address, string phoneNumber)
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
        }
        #endregion 

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

        #region Methods
        public override string ToString()
        {
            return $"Name: - {Name} Address: {Address} - Phonenumber: {PhoneNumber}";
        }
        string phone = "";
        public void PrintCustomer(string phone)
        {
            foreach (Customer c in AllCustomers)
                if (c.PhoneNumber == phone)
                {
                    Console.WriteLine(c);
                }
        }
        public void PrintAllCustomers()
        {
            foreach (Customer c in AllCustomers)
            {
                 Console.WriteLine(c);
            }
        }
        #endregion 
    }
}
