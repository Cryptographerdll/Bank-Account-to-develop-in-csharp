using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Develop a C# app that will determine whether any of several department store customers has exceeded the credit limit on a charge account. For each customer, the following facts are available:
              a) account number
              b) balance at the beginning of the month
              c) total of all items charged by the customer this month
              d) total of all credits applied to the customer’s account this month
              e) allowed credit limit.
              The app should input all these facts as integers, calculate the new balance (= beginning balance + charges – credits), 
              display the new balance and determine whether the new balance exceeds the customer’s credit limit.
              For those customers whose credit limit is exceeded, the app should display the message "Credit limit exceeded". 
              Use sentinel-controlled repetition to obtain the data for each account.
            */

            string accountNumber;
            decimal startBalance;
            decimal charges;
            decimal credits;
            decimal creditLimits;

            Console.WriteLine("please enter the account number \n");
            accountNumber = Console.ReadLine();

            Console.WriteLine("please enter the start balance \n");
            startBalance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("please enter the charges \n");
            charges = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("please enter the credits \n");
            credits = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("please enter the creditLimits \n");
            creditLimits = Convert.ToDecimal(Console.ReadLine());

            bankAccount Account = new bankAccount(accountNumber, startBalance, charges, credits, creditLimits);

            Console.Write("the summary is #{0}", Account.AccountNumber);

            if (Account.ClaculateNewBalance() > Account.CreditLimits)
                Console.Write("sorry you have excedeed your credit limits sir ");
            else
                Console.Write("your current balance is {0}", Account.ClaculateNewBalance());
            Console.Write("your credit is {0}", Account.CreditLimits - Account.ClaculateNewBalance());
        }
    }
}
