using System;

namespace Bakery.Models
{
    public class Bread
    {
        private static double _Price = 5;
        private double _Discount;
        public int Quantity { get; set; }

        public static double Price
        {
            get {return _Price; }
            set {_Price = value; }
        }

        public Bread(int quantity)
        {
            _Price = Price;
            _Discount = 0;
            Quantity = quantity;
        }

        public double BreadCost()
        {
            double breadTotal = 0;
            for (int index = 0; index <= Quantity; index ++)
            {
                if (index == 0)
                {
                    breadTotal += 0;
                }
                else if (index % 3 == 0)
                {
                    breadTotal += _Price * _Discount;
                }
                else
                {
                    breadTotal += _Price;
                }
            }
            return breadTotal;
        }
    }

    public class Pastry
    {
        private static double _PastryPrice = 2;
        private double _Discount;
        public int Quantity { get; set; }

        public static double Price
        {
            get { return _PastryPrice; }
            set { _PastryPrice = value; }
        }

        public Pastry(int quantity)
        {
            _PastryPrice = Price;
            _Discount = -1;
            Quantity = quantity;
        }

        public double PastryCost()
        {
            double pastryTotal = 0;
            for (int index = 0; index <= Quantity; index++)
            {
                if (index == 0)
                {
                    pastryTotal += 0;
                }
                else if (index % 3 == 0)
                {
                    pastryTotal += _PastryPrice + _Discount;
                }
                else
                {
                    pastryTotal += _PastryPrice;
                }
            }
            return pastryTotal;
        }
    }
}