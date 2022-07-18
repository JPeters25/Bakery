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

        [TestMethod]
        public void BreadCost_ThirdLoafIsFree_Int()
        {
            int breadQuantity = 3;
            double breadCost = 10;
            Bread breadOrder = new Bread(breadQuantity);
            Assert.AreEqual(breadCost, breadOrder.BreadCost());
        }

        [TestMethod]
        public void BreadCost_ThirdLoafIsDicountedSixLoafsOrdered_Int()
        {
            int breadQuantity = 6;
            double breadCost = 20;
            Bread breadOrder = new Bread(breadQuantity);
            Assert.AreEqual(breadCost, breadOrder.BreadCost());

        }

    // PastryTests
    //
        [TestMethod]
        public void PastryCost_CostOneNoDiscount_Int()
        {
            int pastryQuantity = 1;
            double pastryCost = 2;

            Pastry pastryOrder = new Pastry(pastryQuantity);

            Assert.AreEqual(pastryCost, pastryOrder.PastryCost());            
        }

        
        [TestMethod]
        public void PastryCost_CostOfTwoLoafDiscounted_Int()
        {
            int pastryQuantity = 3;
            double pastryCost = 5;
            Pastry pastryOrder = new Pastry(pastryQuantity);
            Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
        }

    }
}