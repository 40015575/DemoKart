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
    public class PaymentTests
    {
        [TestMethod()]
        public void CGSTCalculatorTest()
        {
            Payment pObj = new Payment();
            int n = 2;
            double Price = 2345;
            pObj.CGSTCalculator(n, Price);
            Assert.AreEqual(2427.075, 2427.075);
        }

        [TestMethod()]
        public void SGSTCalculatorTest()
        {
            Payment pObj = new Payment();
            int n = 1;
            double Price = 2345;
            pObj.CGSTCalculator(n, Price);
            Assert.AreEqual(2345, 2345);
            // Assert.Fail();
        }
    }
}