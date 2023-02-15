using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmissionsRegressionApplication
{
    internal class Regression
    {
        /// <summary>
        /// This method calculates the regression of the given co2 emission
        /// </summary>
        /// <param name="value">co2 emission of a certain year</param>
        /// <returns>Predicton of the temperature that year</returns>
        public double calculateRegression(int value)
        {
            //values of the co2 emission
            long x = 1794770;
            double y = 516.44;
            double xy = 46404001.40;
            long x2 = 170799610300;
            int n = 20;
            
            //calculations
            double aNumerator = (y) * (x2) - (x) * (xy);
            double aDenominator = n * (x2) - (x * x);
            double a = aNumerator / aDenominator;

            double bNumerator = (n) * (xy) - (x) * (y);
            double bDenominator = (n) * (x2) - (x * x);
            double b = bNumerator / bDenominator;

            return a + b * value;
        }
    }
}
