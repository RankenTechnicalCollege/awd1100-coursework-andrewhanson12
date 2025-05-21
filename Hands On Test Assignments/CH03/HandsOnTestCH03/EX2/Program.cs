using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userNumber = 0;

            Console.WriteLine("Enter a number:");
            userNumber += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number:");
            userNumber += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number:");
            userNumber += Convert.ToDouble(Console.ReadLine());

            double numberAverage = userNumber / 3;
            Console.WriteLine("The average is {0}.", numberAverage);
            Console.ReadKey();
        }
    }
}