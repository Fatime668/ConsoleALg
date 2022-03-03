using System;

namespace Algorithm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine(number1 +"is"+ " larger than " + number2);
            }else if (number2 > number1)
            {
                Console.WriteLine(number2 + " is" + " larger than " + number1);
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }
        }
    }
}
