using System;
using WindChill.Meteorology;

namespace WeatherConsole {
    class TestChill {
        static void Main(string[] args) {

            // Assign values to variable for WindChillFactor constructor
            //  WindChillFactor(TemperatureScale.Scale inScale, WindSpeedUnit.Unit inUnit, int inDegrees, int inWindSpeed)
            TemperatureScale.Scale tempScala = TemperatureScale.Scale.Celsius;
            int degreesCelsius = 5;
            WindSpeedUnit.Unit windUnit = WindSpeedUnit.Unit.MeterPerSecond;
            int windMps = 9;

            // Create WindChillFactor object using the variables from above
            WindChillFactor wChillF = new WindChillFactor(tempScala, windUnit, degreesCelsius, windMps);
            // Then calculate the resulting temperature
            wChillF.CalulateChillFactorTemperature();

            // Print input values and resulting temperature using the WindChillFactor object
            Console.WriteLine("Temperature: " + wChillF.TempDegrees + " " + wChillF.TempScale);
            Console.WriteLine("Wind: " + wChillF.WindSpeed + " " + wChillF.WindUnit);
            Console.WriteLine("Chill " + wChillF.ChillFactorTemperature);

            /*
             * If result wrong, then debug CalulateChillFactorTemperature()
             * Tip: Verify initial conversion from celsius to fahrenheit
             */

            Console.ReadLine();

        }
    }
}
