using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAMC.Temperatura;
using System;

namespace CAMC.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            //Arrange
            TemperatureConverter converter = new TemperatureConverter();

            //Act
            double r1 = converter.CelsiusToFahrenheit(0);
            double r2 = converter.CelsiusToFahrenheit(100);
            double r3 = converter.CelsiusToFahrenheit(-40);

            //Assert
            Assert.AreEqual(32.0, r1);
            Assert.AreEqual(212.0, r2);
            Assert.AreEqual(-40.0, r3);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            //Arrange
            TemperatureConverter converter = new TemperatureConverter();

            //Act
            double r1 = converter.FahrenheitToCelsius(32);
            double r2 = converter.FahrenheitToCelsius(212);
            double r3 = converter.FahrenheitToCelsius(-40);

            //Assert
            Assert.AreEqual(0.0, r1);
            Assert.AreEqual(100.0, r2);
            Assert.AreEqual(-40.0, r3);
        }
    }
}
