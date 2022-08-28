using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_Assignment
{
    class Assignment_6
    {
        static void Main(string[] args)
        {
            Reply:
            int year = Util.GetNumber("Enter the year");
            int month = Util.GetNumber("Enter the month");
            int date = Util.GetNumber("Enter the date");
            bool result = isValidDate(year,month,date);
            if(result==true)
                Console.WriteLine("The date is valid");
            else
                Console.WriteLine("The date is invalid");
            string option = Util.GetString("Enter 1 for continue or any other number to exit");
            if (option == "1")
                goto Reply;
            else
                Environment.Exit(0);
        }
        static bool isValidDate(int year, int month, int day)
        {
            if(month>12 || day>31 || year<1000)
             return false;
            if ((month==2||month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
                return false;
            if(month==2 && day ==29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))) { 
                  return true;   
            }
            return true;
        }
    }
}
