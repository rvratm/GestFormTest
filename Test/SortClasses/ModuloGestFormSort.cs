using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestForm
{
    /// <summary>
    /// Modulo based sort class
    /// </summary>
    public class ModuloGestFormSort : GestFormSortBase
    {
        /// <summary>
        /// Display name
        /// </summary>
        const string _NAME = "Modulo based sort";
        
        /// <summary>
        /// Constructor
        /// </summary>
        public ModuloGestFormSort()
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
            return value % 3 == 0;
        }

        /// <summary>
        /// Test if an integer is a multiple of 5
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        override protected bool MultOf5Test(int value)
        {
            return value % 5 == 0;
        }
    }
}
