using System;

namespace TestAverages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double testScores = 0;
            Console.WriteLine("Enter test score:");
            testScores += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter test score:");
            testScores += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter test score:");
            testScores += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter test score:");
            testScores += Convert.ToDouble(Console.ReadLine());

            double testAverage = testScores / 4;
            Console.WriteLine("The average test score is {0}", testAverage);
            Console.ReadKey();
        }
    }
}
