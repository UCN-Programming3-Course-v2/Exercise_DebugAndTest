using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindChill.Meteorology;

namespace TestMeteorology {

    [TestClass]
    public class TestMeteorology {

        [TestMethod]
        public void TestConvertCelsiusToFahrenheitNormal() {

            // Arrange
            TemperatureScale.Scale tempScale = TemperatureScale.Scale.Celsius;
            int degreesCelsius = 5;
            WindChillFactor wChillFactor = new WindChillFactor(tempScale, WindSpeedUnit.Unit.MeterPerSecond, degreesCelsius, 0);
            double fahrenheitExpected = 41.00;

            // Act
            double fahrenheitResult = wChillFactor.ConvertCelsiusToFahrenheit(degreesCelsius);

            // Assert
            Assert.AreEqual(fahrenheitExpected, fahrenheitResult, 0.001);
        }

        [TestMethod]
        public void TestConvertFahrenheiToCelsiusNormal() {

            // Arrange
            TemperatureScale.Scale tempScale = TemperatureScale.Scale.Fahrenheit;
            int degreesFahrenheit = 50;
            WindChillFactor wChillFactor = new WindChillFactor(tempScale, WindSpeedUnit.Unit.MeterPerSecond, degreesFahrenheit, 0);
            double celsiusExpected = 10;

            // Act
            double fahrenheitResult = wChillFactor.ConvertFahrenheitToCelsius(degreesFahrenheit);

            // Assert
            Assert.AreEqual(celsiusExpected, fahrenheitResult, 0.001);
        }

        [TestMethod]
        public void TestConvertMilesPerHourToMeterPerSecondNormal() {

            // Arrange
            WindSpeedUnit.Unit tempWindUnit = WindSpeedUnit.Unit.MilesPerHour;
            TemperatureScale.Scale tempScale = TemperatureScale.Scale.None;
            int degrees = 0;
            int milesPerHour = 20;
            WindChillFactor wChillFactor = new WindChillFactor(tempScale, tempWindUnit, degrees, milesPerHour);
            double msExpected = 8.9408;

            // Act
            double convertResult = wChillFactor.ConverMilesPerHourToMeterPerSecond(20);

            // Assert
            Assert.AreEqual(msExpected, convertResult, 0.001);
        }

        [TestMethod]
        public void TestConvertMeterPerSecondToMilesPerHourNormal() {

            // Arrange
            WindSpeedUnit.Unit tempWindUnit = WindSpeedUnit.Unit.MeterPerSecond;
            TemperatureScale.Scale tempScale = TemperatureScale.Scale.None;
            int degrees = 0;
            int meterPerSecond = 10;
            WindChillFactor wChillFactor = new WindChillFactor(tempScale, tempWindUnit, degrees, meterPerSecond);
            double mphExpected = 22.36936;

            // Act
            double convertResult = wChillFactor.ConverMeterPerSecondToMilesPerHour(meterPerSecond);

            // Assert
            Assert.AreEqual(mphExpected, convertResult, 0.00001);
        }

        [TestMethod]
        public void TestCalulateChillFactorTemperatureNormal() {

            // Arrange
            WindSpeedUnit.Unit tempWindUnit = WindSpeedUnit.Unit.MeterPerSecond;
            TemperatureScale.Scale tempScale = TemperatureScale.Scale.Celsius;
            int degrees = 5;
            int meterPerSecond = 9;
            WindChillFactor wChillFactor = new WindChillFactor(tempScale, tempWindUnit, degrees, meterPerSecond);
            double temperaturExpected = -0.1;

            // Act
            wChillFactor.CalulateChillFactorTemperature();
            double computeResult = wChillFactor.ChillFactorTemperature;

            // Assert
            Assert.AreEqual(temperaturExpected, computeResult, 0.1);
        }
    }

}
