using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GestForm
{
    /// <summary>
    /// Digit based sort class
    /// </summary>
    public class DigitGestFormSort : GestFormSortBase
    {
        /// <summary>
        /// Sort display name
        /// </summary>
        const string _NAME = "Digit based sort";
                
        /// <summary>
        /// Constructor
        /// </summary>
        public DigitGestFormSort()
        {
            _Name = _NAME;
        }

        /// <summary>
        /// Test if an integer is a multiple of 3
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        override protected bool MultOf3Test(int value)
        {
            if (value == 0) return true;

            int d1, d2, d3, sum = Math.Abs(value);
            while (sum >= 10)
            {
                d3 = sum / 100;
                d2 = (sum - d3 * 100) / 10;
                d1 = sum - (sum / 10) * 10;
                sum = d1 + d2 + d3;
            }
            return sum == 3 || sum == 6 || sum == 9;
        }

        /// <summary>
        /// Test if an integer is a multiple of 5
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        override protected bool MultOf5Test(int value)
        {
            var d1 = value - (value / 10) * 10;
            return d1 == 0 || d1 == 5;
        }
    }
}
