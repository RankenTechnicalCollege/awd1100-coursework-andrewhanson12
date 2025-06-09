using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> testList = new List<double>();
            double testScore;
            while (true)
            {
                Console.WriteLine("Please Enter a Test Score");
                if (double.TryParse(Console.ReadLine(), out testScore))
                {
                    if (testScore >= 0 && testScore <= 100)
                    {
                        testList.Add(testScore);
                    }
                    if (testScore < 0 || testScore > 100 && testScore < 999)
                    {
                        Console.WriteLine("Invalid Score");
                    }
                    if (testScore == 999)
                    {
                        if (testList.Count > 0)
                        {
                            double sum = 0;
                            double min = testList[0];
                            double max = testList[0];
                            foreach (double d in testList)
                            {
                                sum += d;
                                if (d < min) min = d;
                                if (d > max) max = d;
                            }
                            double average = sum / testList.Count;
                            Console.WriteLine($"Number of Scores: {testList.Count}");
                            Console.WriteLine($"Sum of Test Scores: {sum}");
                            Console.WriteLine($"Average Test Score {average}");
                            Console.WriteLine($"Lowest Score: {min}");
                            Console.WriteLine($"Maximum Score: {max}");
                        }
                    }
                }
            }
        }
    }
}