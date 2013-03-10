using System;
using System.Linq;

namespace BankDemo
{
    public abstract class Customer
    {
        private String firstName;
        private String middleName;
        private String lastName;
        private String adress;
        private String phoneNumber;

        public String FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("First name should contain something!");
                else
                   this.firstName = value;
            }
        }

        public String MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Middle name should contain something!");
                else
                    this.middleName = value;
            }
        }

        public String LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Last name should contain something!");
                else
                    this.lastName = value;
            }
        }

        public String Adress
        {
            get
            {
                return this.adress;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Adress should contain something!");
                else
                    this.adress = value;
            }
        }

        public String PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Phone number should contain a phone number!");
                else
                    this.phoneNumber = value;
            }
        }

        public Customer(string firstName, string middleName, string lastName, string adress, string phoneNumber)
        {
            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(middleName) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(adress) || String.IsNullOrEmpty(phoneNumber))
            {
                throw new ArgumentNullException("The constructor contains null value!");
            }
            else
            {
                FirstName = firstName;
                MiddleName = middleName;
                LastName = lastName;
                Adress = adress;
                PhoneNumber = phoneNumber;
            }
        }

        public override string ToString()
        {
            return String.Format("\t{0} {1} {2}\n\t{3}\n\t{4}", FirstName, MiddleName, LastName, Adress, PhoneNumber);
        }
    }
}
