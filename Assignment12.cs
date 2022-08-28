using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_Assignment
{
    abstract class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public double Balance { get;  set; } 
        public void Credit(double amount) => Balance += amount;

        public void Debit(double amount)
        {
            if (Balance < amount)
            {
                throw new Exception("Insufficient funds!!!");
            }
            Balance -= amount;
        }

        public abstract void CalculateInterest();

    }

    class SBAccount : Account
    {
        
        public override void CalculateInterest()
        {
            double principle = Balance;
            double rate = 0.065;
            double term = 0.5;// Half yearly

            var interest = principle * rate * term;
            Credit(interest);
        }
    }
    class RDAccount : Account
    {
        public override void CalculateInterest()
        {
            double principle = Balance;
            int time = Util.GetNumber("Enter the number of months");
            double rate = 8;
            var interest = principle * time * (time + 1) * rate / 2400;
            Credit(interest);
        } 
    }
    class FDAccount : Account
    {
        public override void CalculateInterest()
        {
            double principle = Balance;
            double rate = 0.005;
            int year = Util.GetNumber("Enter the year");
            var interest = principle * year * rate;
            Credit(interest);
        }
    }
    class Assignment12
    {
        static void Main(string[] args)
        {
            Reply:
            String accountType = Util.GetString("Enter the type of account SB or FD or RD");
            switch(accountType)
            {
                case "SB":
                    SBAccount();
                    break;
                case "FD":
                    FDAccount();
                    break;
                case "RD":
                    RDAccount();
                    break;
                default:
                    Console.WriteLine("Please enter the valid choice as SB,RD,FD");
                    goto Reply;


            }

        }

        private static void RDAccount()
        {
            Account ac = new RDAccount();
            ac.Balance = Util.GetNumber("Enter the amount");
            ac.AccountId = 2;
            ac.Name = "Adarsh";
            ac.CalculateInterest();
            Console.WriteLine("The current balance is " + ac.Balance);
        }

        private static void FDAccount()
        {
            Account ac = new FDAccount();
            ac.Balance = Util.GetNumber("Enter the amount");
            ac.AccountId = 2;
            ac.Name = "Adarsh";
            ac.CalculateInterest();
            Console.WriteLine("The current balance is " + ac.Balance);
        }

        private static void SBAccount()
        {
            Account ac = new SBAccount();
            ac.Balance = Util.GetNumber("Enter the amount");
            ac.AccountId = 2;
            ac.Name = "Adarsh";
            ac.CalculateInterest();
            Console.WriteLine("The current balance is "+ac.Balance);
        }
    }
}


