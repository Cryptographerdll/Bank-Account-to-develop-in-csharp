using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class bankAccount
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
        public string AccountNumber { get; set; }
        public decimal StartBalance { get; set; }
        public decimal Charges { get; set; }
        public decimal Credits { get; set; }
        public decimal CreditLimits { get; set; }

        public bankAccount(string accountNumber, decimal startBalance, decimal charges, decimal credits, decimal creditLimits)
        {
            this.AccountNumber = accountNumber;
            this.StartBalance = startBalance;
            this.Charges = charges;
            this.Credits = credits;
            this.CreditLimits = creditLimits;
        }

        public decimal ClaculateNewBalance()
        {
            return (StartBalance + Charges - Credits);
        }
    }
}
