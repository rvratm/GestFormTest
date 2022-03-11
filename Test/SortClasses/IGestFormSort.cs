﻿using System;
using System.Collections.Generic;

namespace GestForm
{
    /// <summary>
    /// Integer list GestForm sort generic interface
    /// </summary>
    public interface IGestFormSort
    {
        /// <summary>
        /// Return the name of the sort
        /// </summary>
        /// <returns></returns>
        string GetName();

        /// <summary>
        /// Sort an integer list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        Tuple<Dictionary<int, string>, TimeSpan> Sort(List<int> list);
    }
}
