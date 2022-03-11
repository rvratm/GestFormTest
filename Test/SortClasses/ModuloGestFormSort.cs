using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestForm
{
    public class ModuloGestFormSort : GestFormSortBase
    {
        const string _NAME = "Modulo based sort";

        override public Dictionary<int, string> Sort(List<int> values)
        {
            var res = new Dictionary<int, string>(values.Count());
            return res;
        }

        public ModuloGestFormSort()
        {
            _Name = _NAME;
        }
    }
}
