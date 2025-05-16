using System;

namespace MilesToKm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double KM_PER_MILE = 1.6;
            double milesToKM = miles * KM_PER_MILE;
            Console.WriteLine("{0} miles is the same as {1} kilmometers.", miles, milesToKM);
            Console.ReadKey();
        }
    }
}

