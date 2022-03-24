using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        /*one called FahrenheitToCelsius that will require a double as a 
            parameter and return a double, the other CelsiusToFahrenheit 
            which will also require a double as a parameter and return a double. 
            Fill out these methods and call them in your Program.cs file.
            Make sure they’re accurate!*/
        public static double FahrenheitToCelsius(double fahrtemp)
        {
            return Math.Round(((fahrtemp - 32.0) * .55), 2);
        }
        public static double CelsiusToFahrenheit(double celsTemp)
        {
            return Math.Round((celsTemp * 1.8 + 32.0), 2);
        }
    }
}
