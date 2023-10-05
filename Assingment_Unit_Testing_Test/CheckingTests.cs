using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_Unit_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing.Tests
{
    [TestClass()]
    public class CheckingTests
    {
        [TestMethod()]
        public void DepositTest()
        {
            // Arrange
            var tc = new Checking(0);
            // ACT
            tc.Deposit(200);
            // Assert
            Assert.AreEqual(200, tc._balance);
        }
        [TestMethod()]
        public void DepositTestNV()
        {
            // Arrange
            var tc = new Checking(100);
            // ACT
            tc.Deposit(-5);
            // Assert
            Assert.AreEqual(100, tc._balance);
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            // Arrange
            var tc = new Checking(1000);
            // ACT
            tc.Withdraw(500);
            // Assert
            Assert.AreEqual(500, tc._balance);
        }
        
        [TestMethod()]
        public void WithdrawTestOC()
        {
            // Arrange
            var tc = new Checking(100);
            // ACT
            tc.Withdraw(200);
            // Assert
            Assert.AreEqual(-115, tc._balance);
        }
    }
}