using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double danielleSales = 0;
            double edwardSales = 0;
            double francisSales = 0;
            string initialEntered = "";

            while (true) 
            {
                Console.WriteLine("Who made the sale?");
                initialEntered = Console.ReadLine();
                if (initialEntered == "z")
                {
                    Console.WriteLine($"Danielle Sales: {danielleSales:C}");
                    Console.WriteLine($"Edward Sales: {edwardSales:C}");
                    Console.WriteLine($"Francis Sales: {francisSales:C}");
                    double sum = danielleSales + francisSales + edwardSales;
                    Console.WriteLine($"Grand Total: {sum:C}");
                    if (danielleSales > edwardSales && danielleSales > francisSales)
                    {
                        Console.WriteLine("Danielle has the most sales");
                    }
                    else if (edwardSales > francisSales && edwardSales > danielleSales)
                    {
                        Console.WriteLine("Edward has the most sales");
                    }
                    else if (francisSales > danielleSales && francisSales > edwardSales)
                    {
                        Console.WriteLine("Francis has the most sales");
                    }
                }
                Console.WriteLine("How much was the sale?");
                double salesEntered = Convert.ToDouble(Console.ReadLine());


                if (initialEntered == "d")
                {
                    danielleSales += salesEntered;
                }
                else if (initialEntered == "e")
                {
                    edwardSales += salesEntered;
                }
                else if (initialEntered == "f")
                {
                    francisSales += salesEntered;
                }
            } 



        }
    }
}
