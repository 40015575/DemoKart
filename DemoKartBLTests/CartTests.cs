using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void AddToCartTest()
        {
            Cart CObj = new Cart();
            int quantity = 10;
            CObj.AddToCart(quantity);
            Assert.AreEqual(0, 0);

            //Assert.Fail();
        }

        [TestMethod()]
        public void AddToCartTest1()
        {
            //Assert.Fail();
            Cart CObj = new Cart();
            int quantity = 11;
            CObj.AddToCart(quantity);
            Assert.AreEqual(1, 1);
        }
    }
}