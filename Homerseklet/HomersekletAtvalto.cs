using System;
using System.Collections.Generic;
using System.Text;

namespace Homerseklet
{
    internal class HomersekletAtvalto
    {
        public int Celsius { get; set; };

        public int ToFahrenheit(int celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
