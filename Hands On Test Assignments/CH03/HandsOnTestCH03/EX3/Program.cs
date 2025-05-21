using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your street address:");
            string userAddress = Console.ReadLine();

            Console.WriteLine("Enter your city:");
            string userCity = Console.ReadLine();

            Console.WriteLine("Enter your state:");
            string userState = Console.ReadLine();

            Console.WriteLine("Enter your zip code:");
            string userZip = Console.ReadLine();

            Console.WriteLine("Amount of shirts?");
            double userShirts = Convert.ToDouble(Console.ReadLine());

            double totalPrice = userShirts * 14.99;
            double salesTax = totalPrice * 0.08;
            double amountDue = salesTax + totalPrice;

            Console.WriteLine("Name: {0}", userName);
            Console.WriteLine("Address: {0}", userAddress);
            Console.WriteLine("City: {0}", userCity);
            Console.WriteLine("State: {0}", userState);
            Console.WriteLine("Zip Code: {0}", userZip);
            Console.WriteLine("Quantity: {0}", userShirts);
            Console.WriteLine("---------------------");
            Console.WriteLine("Total price: {0:C}", totalPrice);
            Console.WriteLine("Sales Tax: {0:C}", salesTax);
            Console.WriteLine("Amount due: {0:C}", amountDue);
            Console.ReadKey();
        }
    }
}
