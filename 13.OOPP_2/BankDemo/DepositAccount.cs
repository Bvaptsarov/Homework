using System;
using System.Linq;

namespace BankDemo
{
    public class DepositAccount : Account, IDepositable,IWithdrawable
    {
        public DepositAccount(Customer customer, Decimal balance, Decimal withdraw)
            : base(customer, balance, withdraw)
        {
        }

        public void Deposit(decimal deposit)
        {
            if (deposit < 0)
                throw new ArgumentException("Deposit sum cannot be a negative value!");
            else
                base.Balance += deposit; 
        }

        public void WithDraw(decimal sum)
        {
            if (sum < 0)
                throw new ArgumentException("Withdraw sum cannot be a negative value!");
            else
                base.Balance -= sum;
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (base.Balance <= 1000 && base.Balance >= 0)
                return 0;
            else if(base.Balance > 1000)
                return base.Interest * numberOfMonths;
            else
                throw new ArgumentException("Balance cannot be a negative value!");
        }
    }
}
