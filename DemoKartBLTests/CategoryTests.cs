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
    public class CategoryTests
    {
        [TestMethod()]
        public void PriceCalcTest()
        {
            Category CObj = new Category();
            int Type = 1;
            int Quantity = 4;
            double Price = 245;
            CObj.PriceCalc(Type,Price,Quantity);
            Assert.AreEqual(289.1,289.1);
            //Assert.Fail();
        }
    }
}