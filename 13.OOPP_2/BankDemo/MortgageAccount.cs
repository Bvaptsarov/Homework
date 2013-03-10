using System;

namespace BankDemo
{
    public class MortgageAccount : Account,IDepositable
    {
        public MortgageAccount(Customer customer, Decimal balance, Decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal deposit)
        {
            if (deposit < 0)
                throw new ArgumentException("Deposit sum cannot be a negative value!");
            else
                base.Balance += deposit; 
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (base.Client is IndividualCustomer)
            {
                if (numberOfMonths <= 6 && numberOfMonths >= 0)
                    return 0;
                else if (numberOfMonths > 6)
                    return base.Interest * numberOfMonths;
                else
                    throw new ArgumentException("Months must be a positive number");
            }
            else if (base.Client is CompanyCustomer)
            {
                if (numberOfMonths <= 12 && numberOfMonths >= 0)
                    return (decimal)(base.Interest /2 * numberOfMonths);
                else if (numberOfMonths > 12)
                    return base.Interest * numberOfMonths;
                else
                    throw new ArgumentException("Months must be a positive number");
            }
            else return 0;
        }
    }
}
