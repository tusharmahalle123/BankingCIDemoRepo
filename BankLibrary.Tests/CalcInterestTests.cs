using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankingLibrary;

namespace BankLibrary.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [TestMethod]
        public void SimpInterest_AcceptPNR_SI()
        {
            int expectedout = 100;
            CalcInterest c = new CalcInterest();
            int actaulout = c.SimpInterest(1000,10,1);
            Assert.AreEqual(expectedout, actaulout);    
        }
    }
}
