using System;   
using System.Linq;

namespace BankDemo
{
    public abstract class Account
    {
        public Customer Client { get; private set; }

        private Decimal balance;
        private Decimal interest;
        
        public Decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Balance cannot be a negative value!");
                else 
                    this.balance = value;
            }
        }
        
        public Decimal Interest
        {
            get
            {
                return this.interest;
            }
            protected set
            {
                if(value<0)
                    throw new ArgumentOutOfRangeException("Interest rate cannot be a negative value!");
                else 
                    this.interest = value;
            }
        }

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            if (balance < 0 || interestRate < 0)
            {
                throw new ArgumentOutOfRangeException("Interest rate and balance cannot contain a negative value!");
            }
            else
            {
                Client = customer;
                Balance = balance;
                Interest = interestRate;
            }
        }

        public virtual Decimal CalculateInterest(int numberOfMonths)
        {
            return numberOfMonths * Interest;
        }

        public override string ToString()
        {
            return String.Format("{0}\n\tBalance - {1}\n\tInterest rate - {2}", Client.ToString(), Balance, Interest);
        }
    }
}
