using System;
using System.Collections.Generic;
using System.Text;

namespace Homerseklet
{
    internal class HomersekletAtvalto
    {
        public int Celsius { get; set; }

        public int ToFahrenheit()
        {
            return (10 * 9 / 5) + 32;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
