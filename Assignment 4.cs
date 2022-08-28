using System;
namespace FAI_assingments
{


    class evenodd
    {



        public static void Main()
        {
            even_odd();
        }

        private static void even_odd()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int even = 0, odd = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    even += arr[i];
                else
                    odd += arr[i];
            }

            Console.WriteLine("Even index positions"
                                + " sum: " + even);

            Console.WriteLine("Odd index positions "
                                + "sum: " + odd);
        }
    }
}

