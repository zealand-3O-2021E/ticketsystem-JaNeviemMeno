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


        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LicensePlate()
        {
            Car car = new();
            car.LicensePlate = "12345678";
            Assert.Fail();
        }
    }
}