using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestForm;
using System.Collections.Generic;
using System;
using System.Linq;

namespace GestFormSortTest
{
    [TestClass]
    public class GestFormSortTest
    {
        List<int> list1, list2, list3, list4;


        [TestInitialize]
        public void TestInitialize()
        {
            list1 = new List<int>() { -1000, 1, 2, 3 };
            list2 = new List<int>() { 1, 2, 3, 1000 };
            list3 = new List<int>() { -999, 999 };
            list4 = new List<int>() { 0, 1, 3, 5, 9, 10, 15 };
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ModuloGestFormSortOutOfBoundsTest1()
        {
            // Prepare
            var sort = new ModuloGestFormSort();

            // Perform
            sort.Sort(list1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ModuloGestFormSortOutOfBoundsTest2()
        {
            // Prepare
            var sort = new ModuloGestFormSort();

            // Perform
            sort.Sort(list2);
        }

        [TestMethod]
        public void ModuloGestFormSortTest()
        {
            // Prepare
            var sort = new ModuloGestFormSort();

            // Perform
            var res1 = sort.Sort(list3);
            var res2 = sort.Sort(list4);

            // Check
            Assert.AreEqual(GestFormSortBase.MultOf3Result, res1.Item1.Values.ElementAt(0));
            Assert.AreEqual(GestFormSortBase.MultOf3Result, res1.Item1.Values.ElementAt(1));
            Assert.AreEqual(GestFormSortBase.MultOfBothResult, res2.Item1.Values.ElementAt(0));
            Assert.AreEqual("1", res2.Item1.Values.ElementAt(1));
            Assert.AreEqual(GestFormSortBase.MultOf3Result, res2.Item1.Values.ElementAt(2));
            Assert.AreEqual(GestFormSortBase.MultOf5Result, res2.Item1.Values.ElementAt(3));
            Assert.AreEqual(GestFormSortBase.MultOf3Result, res2.Item1.Values.ElementAt(4));
            Assert.AreEqual(GestFormSortBase.MultOf5Result, res2.Item1.Values.ElementAt(5));
            Assert.AreEqual(GestFormSortBase.MultOfBothResult, res2.Item1.Values.ElementAt(6));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DigitGestFormSortOutOfBoundsTest1()
        {
            // Prepare
            var sort = new ModuloGestFormSort();

            // Perform
            sort.Sort(list1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DigitGestFormSortOutOfBoundsTest2()
        {
            // Prepare
            var sort = new ModuloGestFormSort();

            // Perform
            sort.Sort(list2);
        }

        [TestMethod]
        public void DigitGestFormSortTest()
        {
            // Prepare
            var sort = new DigitGestFormSort();

            // Perform
            var res1 = sort.Sort(list3);
            var res2 = sort.Sort(list4);

            // Check
            Assert.AreEqual(GestFormSortBase.MultOf3Result, res1.Item1.Values.ElementAt(0));
            Assert.AreEqual(GestFormSortBase.MultOf3Result, res1.Item1.Values.ElementAt(1));
            Assert.AreEqual(GestFormSortBase.MultOfBothResult, res2.Item1.Values.ElementAt(0));
            Assert.AreEqual("1", res2.Item1.Values.ElementAt(1));
            Assert.AreEqual(GestFormSortBase.MultOf3Result, res2.Item1.Values.ElementAt(2));
            Assert.AreEqual(GestFormSortBase.MultOf5Result, res2.Item1.Values.ElementAt(3));
            Assert.AreEqual(GestFormSortBase.MultOf3Result, res2.Item1.Values.ElementAt(4));
            Assert.AreEqual(GestFormSortBase.MultOf5Result, res2.Item1.Values.ElementAt(5));
            Assert.AreEqual(GestFormSortBase.MultOfBothResult, res2.Item1.Values.ElementAt(6));
        }
    }
}
