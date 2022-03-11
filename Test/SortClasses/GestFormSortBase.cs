using System;
using System.Collections.Generic;
using System.Text;

namespace GestForm
{
    public abstract class GestFormSortBase : IGestFormSort
    {
        protected string _Name = "Undefined";

        public string GetName()
        {
            return _Name;
        }

        public abstract Dictionary<int, string> Sort(List<int> values);

    }
}
