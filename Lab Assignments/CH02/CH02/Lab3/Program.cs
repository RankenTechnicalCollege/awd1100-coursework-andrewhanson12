using System;

namespace PercentRaise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PERCENT_RAISE = 0.04;
            Console.WriteLine("Enter Name of Employee 1/3");
            string employee1 = Console.ReadLine();
            Console.WriteLine("Enter Salary of Employee 1/3");
            double salary1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Name of Employee 2/3");
            string employee2 = Console.ReadLine();
            Console.WriteLine("Enter Salary of Employee 2/3");
            double salary2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Name of Employee 3/3");
            string employee3 = Console.ReadLine();
            Console.WriteLine("Enter Salary of Employee 3/3");
            double salary3 = Convert.ToDouble(Console.ReadLine());

            double firstYear1 = salary1 + (salary1 * PERCENT_RAISE);
            double firstYear2 = salary2 + (salary2 * PERCENT_RAISE);
            double firstYear3 = salary3 + (salary3 * PERCENT_RAISE);

            double secondYear1 = firstYear1 + (firstYear1 * PERCENT_RAISE);
            double secondYear2 = firstYear2 + (firstYear2 * PERCENT_RAISE);
            double secondYear3 = firstYear3 + (firstYear3 * PERCENT_RAISE);

            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine($"| Year       |   {employee1} |    {employee2}  |     {employee3}   |");
            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine($"| 2025       |{salary1:C}  |{salary2:C}  |{salary3:C}  |");
            Console.WriteLine($"| 2026       |{firstYear1:C}  |{firstYear2:C}  |{firstYear3:C}  |");
            Console.WriteLine($"| 2027       |{secondYear1:C}  |{secondYear2:C}  |{secondYear3:C}  |");
            Console.WriteLine("+------------+------------+------------+------------+");
            Console.ReadKey();
        }
    }
}
