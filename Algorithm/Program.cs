using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2==1)
            {
                Console.WriteLine("It is a odd number");
            }
             else
            {
                Console.WriteLine("It is a even number");
            }
        }
    }
}
