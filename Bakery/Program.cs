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
            Console.WriteLine("");
            Console.WriteLine("A Pastry costs $" + Pastry.Price);
        }
    }
}