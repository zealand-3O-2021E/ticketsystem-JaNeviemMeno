using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            MC motor = new();
            var value = motor.Price();
            Assert.AreEqual(125,value);
        }

        [TestMethod()]
        public void VehicleTest()
        {
            MC motor = new();
            var value = motor.Vehicle();
            Assert.AreEqual("MC", value);
        }
    }
}