using System;
namespace FAI_assingments
{

    class Bank
    {

       
    


    

        
        static void Main(string[] args)
        {
            Console.WriteLine("enter the priciple amount");
            int principle = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the rate");
            int rate = int.Parse(Console.ReadLine());

            Caluclate( principle,year,rate);
       }

        private static void Caluclate(int principle, int year, int rate)
        {
            
            int interest = principle * year * rate / 100;
            Console.WriteLine($"the the intrest is  {interest}");

            int total_amt = principle + interest;
            Console.WriteLine($"the total amount is  {total_amt}");
        }
    }
}
