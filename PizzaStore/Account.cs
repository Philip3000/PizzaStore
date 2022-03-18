using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Account
    {
        #region instance fields
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _mail;
        private string _streetName;
        private string _streetNumber;
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
        
        #region Method
        public void GetDeliveryInfo()
        {
            Console.WriteLine($"Road: {StreetName} nr: {StreetNumber} Phone: {PhoneNumber}");
        }
        public string GetAccountInfo()
        {
            return FirstName + LastName + Mail + StreetName + StreetNumber + PhoneNumber;
        }
      
        public override string ToString()
        {
            return $"First name: {FirstName} - Last name: {LastName} - Phone number: {PhoneNumber} - Mail: {Mail} - Streetname: {StreetName} - StreetNumber {StreetNumber}";
        }
        #endregion
    }
}
