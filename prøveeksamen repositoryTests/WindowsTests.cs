using Microsoft.VisualStudio.TestTools.UnitTesting;
using prøveeksamen_repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prøveeksamen_repository.Tests
{
    [TestClass()]
    public class WindowsTests
    {
        [TestMethod()]
        public void CheckEnergyClassForInvalidValues()
        {
            var window = new Windows();

            // Test invalid energy class values
            char[] invalidValues = { 'D', 'E', 'Z', '1', ' ' };

            foreach (var value in invalidValues)
            {
                Assert.ThrowsException<ArgumentException>(() => window.EnergyClass = value);
            }
        }

        [TestMethod()]
        public void ValidEnergyClassValuesAreAccepted()
        {
            var window = new Windows();

            // Test valid energy class values
            char[] validValues = { 'A', 'B', 'C' };

            foreach (var value in validValues)
            {
                window.EnergyClass = value;
                Assert.AreEqual(value, window.EnergyClass);
            }
        }

        [TestMethod()]
        public void CheckPriceForInvalidValues()
        {
            var window = new Windows();

            // Test invalid price values (zero and negative)
            int[] invalidPrices = { 0, -1, -100 };

            foreach (var price in invalidPrices)
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => window.Price = price);
            }
        }

        [TestMethod()]
        public void ValidPriceValuesAreAccepted()
        {
            var window = new Windows();

            // Test valid price values
            int[] validPrices = { 1, 100, 9999 };

            foreach (var price in validPrices)
            {
                window.Price = price;
                Assert.AreEqual(price, window.Price);
            }
        }

        [TestMethod()]
        public void ToString_Test()
        {
            var window = new Windows
            {
                Id = 10,
                Model = "XK90",
                EnergyClass = 'A',
                Price = 2500
            };

            Assert.AreEqual("Window: Id = 10, Model = XK90, EnergyClass = A, Price = 2500", window.ToString());
        }
    }
}



