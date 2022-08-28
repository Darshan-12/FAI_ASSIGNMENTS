using System;
namespace FAI_assingments
{
    class claculator
    {
        public static void Call()
        {
            Console.WriteLine("enter the two elements");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int ans;
            Console.WriteLine("enter the operations");

            string opertions = Console.ReadLine();

            switch (opertions)
            {




                case "+":
                    ans = (a+b);
                    Console.WriteLine(ans);
                    break;

                case "-":
                    ans = a - b;
                    Console.WriteLine(ans);

                    break;

                case "*":
                    ans = a * b;
                    Console.WriteLine(ans);

                    break;

                case "/":
                    ans = a / b;
                    Console.WriteLine(ans);

                    break;

                case "%":
                    ans = a % b;
                    Console.WriteLine(ans);

                    break;


                default:
                    break;



            }
        }

        static void Main(string[] args)
        {
            Call();
        }
    }
}