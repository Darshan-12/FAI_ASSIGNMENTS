using System;
namespace FAI_assingments
{
    class arr
    {
        public static void display()
        {
            Console.WriteLine( "enter the array size ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter array elements");
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i ]% 2 == 0)
                {
                    Console.WriteLine("its even");
                }
                else
                    Console.WriteLine("its odd");
            }
        }
        static void Main(string[] args)
        {
            display();


        }
    }

  
}

   