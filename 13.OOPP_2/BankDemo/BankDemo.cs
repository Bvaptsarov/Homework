using System;

namespace BankDemo
{
    public class BankDemo
    {   
        static void Main()
        {
            Customer individ = new IndividualCustomer("Borislav", "Ivov", "Vaptsarov", "Sofia,Bulgaria", "+359112");
            LoanAccount forBorislav = new LoanAccount(individ,0,(decimal)7.5);

            Console.WriteLine(forBorislav.CalculateInterest(12)); // what this means is.. that 12 month perz 7.5% is the calculated interest, where the first 3 months are without Interest - so 9*7.5 = ?
            Console.WriteLine(forBorislav);

            Customer company = new CompanyCustomer("DImitur", "Pavlov", "Petrankov", "Rusia", "none");
            LoanAccount forCompany = new LoanAccount(company, 0, 10);
            MortgageAccount forCompanyMorgage = new MortgageAccount(company, 250, 10);

            Console.WriteLine(forCompany.CalculateInterest(6)); // 6 - 2(free from interest months) = 4 * 10% = 40 - Loan Interest
            Console.WriteLine(forCompanyMorgage.CalculateInterest(6)); // 6 months * 10% interest, however it's only 50% of that sum - 60*10/2 = 30
            
            forCompanyMorgage.Deposit(500);
            Console.WriteLine(forCompanyMorgage.ToString());
        }
    }
}
