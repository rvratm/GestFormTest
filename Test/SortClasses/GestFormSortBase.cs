using System;
using System.Collections.Generic;
using System.Text;

namespace GestForm
{
    public abstract class GestFormSortBase : IGestFormSort
    {
        const string _Name = "Modulo sorting";

        public string GetName()
        {
            return _Name;
        }

        public abstract Dictionary<int, string> Sort(List<int> values);

    }
}
