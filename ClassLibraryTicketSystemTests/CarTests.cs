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
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            Car car = new();
            var value = car.Price();
            Assert.AreEqual(240,value);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Car car = new();
            var value = car.VehicleType();
            Assert.AreEqual("car",value);
        }
    }
}