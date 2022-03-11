using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GestForm
{
    public class DigitGestFormSort : GestFormSortBase
    {
        const string _NAME = "Digit based sort";

        override public Dictionary<int, string> Sort(List<int> values)
        {
            var res = new Dictionary<int, string>(values.Count());
            return res;
        }

        public DigitGestFormSort()
        {
            _Name = _NAME;
        }
    }
}
