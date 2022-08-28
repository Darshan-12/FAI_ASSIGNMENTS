using System;


namespace week1_Assignment
{
    class Assignment_7
    {
        
        static void Main(string[] args)
        {
            repeat:
            int input = Util.GetNumber("Enter the number");
            bool result = isPrimeNumber(input);
            if(result==true)
                Console.WriteLine("The number is prime");
            else
                Console.WriteLine("The number is not prime");
            string choice = Util.GetString("Enter 1 to continue and any other number to exit");
            if (choice == "1")
                goto repeat;
            else
                Environment.Exit(0);

            
        }
        static bool isPrimeNumber(int num)
        {
            if (num <= 1)
                return false;

            
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;

            return true;
           
        }
    }
}
