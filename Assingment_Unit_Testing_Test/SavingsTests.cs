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
    public class SavingsTests
    {
        [TestMethod()]
        public void DepositTest()
        {
            // Arrange
            int expected = 300;
            Savings ts = new Savings(0);
            // Act
            ts.Deposit(300);

            // Assert
            Assert.AreEqual(300, ts._balance);
        }

        [TestMethod()]
        public void DepositTestNV()
        {
            // Arrange
            int expected = 200;
            Savings ts = new Savings(200);
            // Act
            ts.Deposit(-20);

            // Assert
            Assert.AreEqual(200, ts._balance);
            //Assert.ThrowsException<ArgumentException>(() => ts._balance);
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            // Arrange
            Savings ts = new Savings(500);
            int expected = 300;
            // Act
            ts.Withdraw(200);
            // Assert
            Assert.AreEqual(300, ts._balance);
        }

        [TestMethod()]
        public void WithdrawTestNA()
        {
            // Arrange
            int expected = 500;
            Savings ts = new Savings(500);
            
            // Act
            ts.Withdraw(-50);
            // Assert
            Assert.AreEqual(500, ts._balance);
        }
    }
}