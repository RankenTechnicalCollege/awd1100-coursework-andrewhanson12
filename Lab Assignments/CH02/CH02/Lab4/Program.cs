using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many days did you rent the car? ");
            double daysAmount = Convert.ToDouble(Console.ReadLine());
            const double COST_PER_DAY = 100;
            double totalDaysCost = daysAmount * COST_PER_DAY;

            Console.WriteLine("How many miles did you drive? ");
            double milesAmount = Convert.ToDouble(Console.ReadLine());
            const double COST_PER_MILE = 0.50;
            double totalMilesCost = milesAmount * COST_PER_MILE;

            double totalCost = totalDaysCost + totalMilesCost;
            Console.WriteLine("Your total is: {0:C}", totalCost);
            Console.ReadKey();
        }
    }
}
