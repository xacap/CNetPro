using NUnit.Framework;
using LibraryHW;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestHW
{
    class OneDimensionalArraysHelperTest
    {
        [TestCase(new int[] { 1, 2 }, 1)]
        [TestCase(new int[] { 5, 6, 2 }, 2)]

        public void FindMinElement_WhenArrayNotNull_ShouldMinValue(
        int[] sourseArray,
        int minValue)
        {
            int actialResult = OneDimensionalArraysHelper.FindMinElement(sourseArray);

            Assert.AreEqual(minValue, actialResult);
        }

        [Test]
        public void FindMinElement_WhenArrayNull_ShouldArgumentException()
        {
            int[] arr = null;

            try
            {
                OneDimensionalArraysHelper.FindMinElement(arr);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Missing array!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 0, 1 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void FindMaxElement_WhenArrayNotNull_ShouldMinValue(
        int[] sourseArray,
        int minValue)
        {
            int actialResult = OneDimensionalArraysHelper.FindMaxElement(sourseArray);
            Assert.AreEqual(minValue, actialResult);
        }

        [Test]
        public void FindMaxElementArray_WhenArrayNull_ShouArgumentExeption()
        {
            int[] array = null;
            try
            {
                OneDimensionalArraysHelper.FindMinElement(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Missing array!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
