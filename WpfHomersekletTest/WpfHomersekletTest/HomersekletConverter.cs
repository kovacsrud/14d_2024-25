using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHomersekletTest
{
    public static class HomersekletConverter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }
    }
}
