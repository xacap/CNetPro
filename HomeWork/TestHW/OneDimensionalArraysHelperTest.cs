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

        public void FindMinElement__WhenArrayIsFilled_ShouldMinValue(
        int[] sourseArray,
        int minValue)
        {
            int actialResult = OneDimensionalArraysHelper.FindMinElement(sourseArray);

            Assert.AreEqual(minValue, actialResult);
        }

        [Test]
        public void FindMinElement_WhenArrayMissing_ShouldNullReferenceException()
        {
            int [] arr = null;
            
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
            
        
    }
}
