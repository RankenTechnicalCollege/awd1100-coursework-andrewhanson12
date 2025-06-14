using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> priceList = new List<double>();
            double priceEntered;

            while (true)
            {
                Console.WriteLine("Enter Price:");
                if (double.TryParse(Console.ReadLine(), out priceEntered))
                {
                    if (priceEntered > 0)
                    {
                        priceList.Add(priceEntered);
                    }
                    if (priceEntered < 0)
                    {
                        Console.WriteLine("Invalid Price");
                    }
                    if (priceEntered == 0)
                    {
                        if (priceList.Count > 0)
                        {
                            double subTotal = 0;
                            foreach (double price in priceList)
                            {
                                subTotal += price;
                            }
                            double averagePrice = subTotal / priceList.Count;
                            double tax = subTotal * 0.08;
                            double grandTotal = subTotal + tax;
                            Console.WriteLine($"Number of items: {priceList.Count}");
                            Console.WriteLine($"Average price: {averagePrice:C}");
                            Console.WriteLine($"Subtotal: {subTotal:C}");
                            Console.WriteLine($"Tax: {tax:C}");
                            Console.WriteLine($"Total: {grandTotal:C}");
                        }
                    }
                }
            }
        }
    }
}

