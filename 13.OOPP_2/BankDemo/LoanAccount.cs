using System;

namespace BankDemo
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, Decimal balance, Decimal interestRate) : base(customer, balance, interestRate)
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
                if (numberOfMonths <= 3 && numberOfMonths >= 1)
                    return 0;
                else if (numberOfMonths > 3)
                    return base.Interest * (numberOfMonths - 3);
                else
                    throw new ArgumentException("Months must be a positive number");
            }
            else if (base.Client is CompanyCustomer)
            {
                if (numberOfMonths <= 2 && numberOfMonths >= 1)
                    return 0;
                else if (numberOfMonths > 2)
                    return base.Interest * (numberOfMonths - 2);
                else
                    throw new ArgumentException("Months must be a positive number");
            }
            else return 0;
        }
    }
}