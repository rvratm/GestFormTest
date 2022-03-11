using System;
using System.Collections.Generic;
using System.Linq;

namespace GestForm
{
    /// <summary>
    /// Console Application Main class
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Starting method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // A list of 2 sort classes in order to compare computation time
            var gestformSortList = new List<IGestFormSort> { new DigitGestFormSort(), new ModuloGestFormSort() };

            // Get a random integer list
            var values = GenRandomIntList(10, -999, 999);
            try
            {
                // Sort and display the result on the console
                gestformSortList.ForEach(s =>
                {
                    var res = s.Sort(values);
                    Display(s.GetName(), res.Item1, res.Item2);

                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Display a sort result on console
        /// </summary>
        /// <param name="name"></param>
        /// <param name="values"></param>
        /// <param name="duration"></param>
        static void Display(string name, Dictionary<int, string> values, TimeSpan duration)
        {
            Console.WriteLine("\n" + name + "\n");
            values.ToList().ForEach(n => Console.WriteLine($"{n.Key}  ---->    {n.Value}"));
            Console.WriteLine($"Duration: {duration.TotalSeconds} sec");
        }


        /// <summary>
        /// Generate a random integer list
        /// </summary>
        /// <param name="nbVal"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static List<int> GenRandomIntList(int nbVal, int min, int max)
        {
            var res = new List<int>(nbVal);
            var rand = new Random();

            for (int i = 0; i < nbVal; i++)
                res.Add(rand.Next(min, max+1));
            return res;
        }
    }
}
