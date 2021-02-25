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
    public class UserTests
    {
        [TestMethod()]
        public void GetauthorizedTest()
        {
            User uObj = new User();
            String UName = "Supriya";
            String Password = "1234";
            uObj.Getauthorized(UName, Password);
            Assert.AreEqual(0, 0);
        }

        [TestMethod()]
        public void GetauthorizedTest1()
        {

            User uObj = new User();
            String UName = "supriya";
            String Password = "1234";
            uObj.Getauthorized(UName, Password);
            Assert.AreEqual(2, 2);
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetauthorizedTest2()
        {
            Assert.Fail();
        }
    }
}