using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingTemperatureConverter
{
    public class TemperatureConverter
    {
        /*
        3. Testing Temperature Converter
Problem:
Create a TemperatureConverter class with:
● CelsiusToFahrenheit(double celsius): Converts Celsius to Fahrenheit.
● FahrenheitToCelsius(double fahrenheit): Converts Fahrenheit to Celsius.
✅ Write unit tests to validate conversions.
        */

        // method to convert cel to farh
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }
        // method to convert cel to farh
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit-32) / 1.8;
        }
    }
}