using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
        #region instance fields
    public class Account
    {
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _mail;
        private string _streetName;
        private string _streetNumber;
        private bool _signIn;
        #endregion 

        #region constructor
        public Account(string firstName, string lastName, string phoneNumber, string mail, string streetName, string streetNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _phoneNumber = phoneNumber;
            _mail = mail;
            _streetName = streetName;
            _streetNumber = streetNumber;
        }
        #endregion 

        #region properties
        public string FirstName
        {
            get { return _firstName; }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public string StreetName
        {
            get { return _streetName; }
            set { _streetName = value; }
        }
        public string StreetNumber
        {
            get { return _streetNumber; }
            set { _streetNumber = value; }
        }
        #endregion    
        
        #region method
        public void GetDeliveryInfo()
        {
            Console.WriteLine($"Vej: {StreetName} nr: {StreetNumber} tlf: {PhoneNumber}");
        }
        public string GetAccountInfo()
        {
            return FirstName + LastName + Mail + StreetName + StreetNumber + PhoneNumber;
        }
        public void SignIn()
        { 
                if (_mail == Mail) { Console.WriteLine($"Sign in successfull"); }
        }
        #endregion
    }
}
