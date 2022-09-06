using System;

namespace WindChill.Meteorology
{
    public class TemperatureScale {
        public enum Scale { None, Celsius, Fahrenheit };

        public static Scale GetScale(string scaleString) {
            Scale foundScale = Scale.None;

            if (scaleString.ToLower().Equals("fahrenheit")) {
                foundScale = Scale.Fahrenheit;
            }
            if (scaleString.ToLower().Equals("celsius")) {
                foundScale = Scale.Celsius;
            }

            return foundScale;
        }
    }
}
