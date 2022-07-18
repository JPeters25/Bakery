using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Models;

namespace Bakery.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Bakery!");
            Console.WriteLine("");
            Console.WriteLine("A loaf of bread costs $" + Bread.Price);
            Console.WriteLine("Summer Special! Buy 2 Loafs, Get 1 free!!");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("A Pastry costs $" + Pastry.Price);
            Console.WriteLine("$1 off for 3 or more, 2 dollars off half-dozen");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Would you like Bread or Pastry?");
            string response = Console.ReadLine();
            if (response == "Bread" || response == "bread")
            {
                Console.WriteLine("How many loafs?");
                int breadOrder = int.Parse(Console.ReadLine());
                Bread userBread = new Bread(breadOrder);
                Console.WriteLine("For " + userBread.Quantity + " loafs of bread. Your total is $" + userBread.BreadCost());
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Would you like to place another order? (Y for yes| N for no)");
                string response2 = Console.ReadLine();
                if (response2 == "Y" || response2 == "y")
                {
                    Main();
                }
                else if (response2 == "N" || response2 == "n")
                {
                    Console.WriteLine("GoodBye!");
                    Environment.Exit(0);
                }
            }
            else if (response == "Pastry" || response == "pastry")
            {
                Console.WriteLine("How many pastries?");
                int pastryOrder = int.Parse(Console.ReadLine());
                Pastry userPastry = new Pastry(pastryOrder);
                Console.WriteLine("For " + userPastry.Quantity + " pastries. Your total is $" + userPastry.PastryCost());
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Would you like to place another order? (Y for yes| N for no)");
                string response3 = Console.ReadLine();
                if (response3 == "Y" || response3 == "y")
                {
                    Main();
                }
                else if (response3 == "N" || response3 == "n")
                {
                    Console.WriteLine("GoodBye!");
                    Environment.Exit(0);
                }
            }
        }
    }
}