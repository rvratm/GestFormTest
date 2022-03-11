using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestForm
{
    /// <summary>
    /// Abstract sort class
    /// </summary>
    public abstract class GestFormSortBase : IGestFormSort
    {
        #region Const        

        /// <summary>
        /// Result displayed if a value is a multiple of 3
        /// </summary>
        public const string MultOf3Result = "Geste";

        /// <summary>
        /// Result displayed if a value is a multiple of 5
        /// </summary>
        public const string MultOf5Result = "Forme";

        /// <summary>
        /// Result displayed if a value is a multiple of 3 and 5
        /// </summary>
        public const string MultOfBothResult = "Gestform";

        /// <summary>
        /// Max authorized value for a list to be valid
        /// </summary>
        const int _MaxAuthorizedValue = 1000;

        /// <summary>
        /// Min authorized value for a list to be valid
        /// </summary>
        const int _MinAuthorizedValue = -1000;
        #endregion

        /// <summary>
        /// Sort class display Name
        /// </summary>
        protected string _Name = "Undefined";

        #region IGestFormSort
        /// <summary>
        /// Return the display name of the sort class
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return _Name;
        }

        /// <summary>
        /// Sort an integer list
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public Tuple<Dictionary<int, string>, TimeSpan> Sort(List<int> values)
        {
            // Start for duration computation
            var start = DateTime.Now;

            var res = new Dictionary<int, string>(values.Count);           

            // Check out of bounds
            CheckListValidity(values);

            // Sort
            values.ForEach(v => res.Add(v, GetValueResult(v)));                            

            return new Tuple<Dictionary<int, string>, TimeSpan>(res, DateTime.Now.Subtract(start));
        }
        #endregion

        #region protected

        /// <summary>
        /// Perform a single value result
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected string GetValueResult(int value)
        {
            var m3 = MultOf3Test(value);
            var m5 = MultOf5Test(value);
            return m3 && m5 ? MultOfBothResult : (m3 ? MultOf3Result : (m5 ? MultOf5Result : value.ToString()));
        }

        /// <summary>
        /// Check List validity
        /// </summary>
        /// <param name="values"></param>
        protected void CheckListValidity(List<int> values)
        {
            if (values.FirstOrDefault(i => i >= _MaxAuthorizedValue || i <= _MinAuthorizedValue) != 0)
                throw new Exception("Value out of bound");
        }

        /// <summary>
        /// Test if an integer is a multiple of 3
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected abstract bool MultOf3Test(int value);

        /// <summary>
        /// Test if an integer is a multiple of 5
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected abstract bool MultOf5Test(int Value);

        #endregion
    }
}
