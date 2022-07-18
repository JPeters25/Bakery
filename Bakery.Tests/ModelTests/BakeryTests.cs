using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]

    public class BreadTests
    {
        [TestMethod]

        public void BreadCost_CostOneLoafNoDiscount_Int()
        {
            int breadQuantity = 1;
            double breadCost = 5;

            Bread breadOrder = new Bread(breadQuantity);

            Assert.AreEqual(breadCost, breadOrder.BreadCost());            
        }
        [TestMethod]

        public void BreadCost_CostTwoLoafNoDiscount_Int()
        {
            int breadQuantity = 2;
            double breadCost = 10;
            Bread breadOrder = new Bread(breadQuantity);
            Assert.AreEqual(breadCost, breadOrder.BreadCost());
        }
    }
}