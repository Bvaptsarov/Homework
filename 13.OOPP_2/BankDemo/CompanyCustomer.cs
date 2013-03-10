using System;
using System.Linq;

namespace BankDemo
{
    public class CompanyCustomer : Customer
    {
        public CompanyCustomer(string firstName, string middleName, string lastName, string adress, string phoneNumber)
            : base(firstName, middleName, lastName, adress, phoneNumber)
        {
        }

        public override string ToString()
        {
            return String.Format("Company customer : \n{0}", base.ToString());
        }
    }
}
