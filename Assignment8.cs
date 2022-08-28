using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_Assignment
{
    class Assignment8
    {
        public static void printcalendar(int year, int month)
        {
            Console.WriteLine("Sat\tSun\tMon\tTue\tWed\tThur\tFri");
            int week = getDay(year, month);
            int day = getDays(year, month);
            for (int i = 0; i < week; i++)
            {
                Console.Write("   \t");
            }
            for (int i = 1; i <= day; i++)
            {
                Console.Write(i + "\t");
                if (i % 7 == (7 - week))
                    Console.WriteLine();
            }
        }
        public static int getDay(int year, int month)
        {
            int h = 0;
            if (month == 1 || month == 2)
            {
                h = (int)(1 + 26 * (month + 12 + 1) / 10 + (year - 1) % 100 * 1.25 + Math.Abs((year - 1) / 100) * 5.25) % 7;
            }
            else
                h = (int)(1 + 26 * (month + 1) / 10 + year % 100 * 1.25 + Math.Abs(year / 100) * 5.25) % 7;
            return h;
        }
        public static int getDays(int year, int month)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    return 31;
                else if (month == 2)
                    return 29;
                else
                    return 30;
            }
            else
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                return 31;
            else if (month == 2)
                return 28;
            else
                return 30;
        }



        public static void Main(string[] args)
        {
        RETRY:
            try
            {

                int year = Util.GetNumber("Enter the year");
                int month =Util.GetNumber("Enter the month");
                printcalendar(year, month);
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Month and year should be number");
                goto RETRY;
            }
        }
    }
}
