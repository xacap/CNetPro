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

        public void GetMinElement_WhenArrayNotNull_ShouldMinValue(
        int[] sourseArray,
        int minValue)
        {
            int actialResult = OneDimensionalArraysHelper.GetMinElement(sourseArray);

            Assert.AreEqual(minValue, actialResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]

        public void GetMinElement_WhenArrayNullOrLenghtZero_ShouldArgumentException(
            int[] arr)
        {
            try
            {
                OneDimensionalArraysHelper.GetMinElement(arr);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Missing array or array length equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 0, 1 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void GetMaxElement_WhenArrayNotNull_ShouldMinValue(
        int[] sourseArray,
        int minValue)
        {
            int actialResult = OneDimensionalArraysHelper.GetMaxElement(sourseArray);
            Assert.AreEqual(minValue, actialResult);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void GetMaxElementArray_WhenArrayNullOrLengthZero_ShouArgumentExeption(
            int[] array)
        {
            try
            {
                OneDimensionalArraysHelper.GetMinElement(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Missing array or array length equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 200 }, 0)]
        [TestCase(new int[] { 32, 7, 45, 10, 5 }, 4)]
        public void GetIndexMinElement_WhenArrayNotNullAndLengthNotZero_ShouldIndexMinElement(
            int[] arr,
            int expectedResoult)
        {
            {
                int actualResoult = OneDimensionalArraysHelper.GetIndexMinElement(arr);
                Assert.AreEqual(expectedResoult, actualResoult);
            }
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void GetIndexMinElement_WhenArrayIsNullOrLengthToZero_ShouArgumentExeption(
            int[] array)
        {
            try
            {
                OneDimensionalArraysHelper.GetIndexMinElement(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Missing array or array length equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 333, 50 }, 0)]
        [TestCase(new int[] { 56, 566, 654, 45, 78 }, 2)]
        public void GetIndexMaxElement_WhenArrayNotNullAndLengthNotZero_ShouldIndexMaxElement(
           int[] arr,
           int expectedResoult)
        {
            {
                int actualResoult = OneDimensionalArraysHelper.GetIndexMaxElement(arr);
                Assert.AreEqual(expectedResoult, actualResoult);
            }
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void GetIndexMaxElement_WhenArrayIsNullOrLengthToZero_ShouArgumentExeption(
            int[] array)
        {
            try
            {
                OneDimensionalArraysHelper.GetIndexMaxElement(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Missing array or array length equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 1, 50 }, 50)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        public void SumElementsWithOddIndex_WhenArrayNotNull_ShouldSumElement(
           int[] arr,
           int expectedResoult)
        {
            {
                int actualResoult = OneDimensionalArraysHelper.SumElementsWithOddIndex(arr);
                Assert.AreEqual(expectedResoult, actualResoult);
            }
        }

        [Test]
        public void SumElementsWithOddIndex_WhenArrayIsNull_ShouldArgumentExeption()
        {
            int[] arr = null;
            try
            {
                OneDimensionalArraysHelper.SumElementsWithOddIndex(arr);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Missing array!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 3 }, 1)]
        [TestCase(new int[] { 1, 50 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        public void CountOddElements_WhenArrayNotNull_ShouldCountElement(
           int[] arr,
           int expectedResoult)
        {
            {
                int actualResoult = OneDimensionalArraysHelper.CountOddElements(arr);
                Assert.AreEqual(expectedResoult, actualResoult);
            }
        }

        [Test]
        public void CountOddElements_WhenArrayIsNull_ShouldArgumentExeption()
        {
            int[] arr = null;

            try
            {
                OneDimensionalArraysHelper.CountOddElements(arr);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Missing array!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        public void SwapHalfArrey_WhenArrayNotNull_ShouldSwapArray(
            int[] sourceArray,
            int[] expectedArray)
        {
            OneDimensionalArraysHelper.SwapHalfArrey(sourceArray);

            Assert.AreEqual(expectedArray, sourceArray);
        }

        [Test]
        public void SwapHalfArrey_WhenArrayIsNull_ShouldArgumentNullExeption()
        {
            int[] arr = null;

            try
            {
                OneDimensionalArraysHelper.SwapHalfArrey(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null. (Parameter 'Array is null!')", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 10, 1 }, new int[] { 1, 10 })]
        [TestCase(new int[] { 5, 2, 4, 1, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        public void SortArrayInsert_WhenArrayNotNull_ShouldArraySorted(
            int[] sourceArray,
            int[] expectedArray
            )
        {
            OneDimensionalArraysHelper.SortArrayInsert(sourceArray);
            Assert.AreEqual(expectedArray, sourceArray);
        }

        [Test]
        public void SortArrayInsert_WhenArrayIsNull_ShouldArgumentNullExeption()
        {
            int[] arr = null;

            try
            {
                OneDimensionalArraysHelper.SwapHalfArrey(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null. (Parameter 'Array is null!')", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 2, 5 }, new int[] { 5, 2 })]
        [TestCase(new int[] { 5, 2, 4, 1, 3 }, new int[] { 5, 4, 3, 2, 1 })]
        public void SortingArraySelect_WhenArrayNotNull_ShouldArraySorted(
            int[] sourceArray,
            int[] expectedArray
            )
        {
            OneDimensionalArraysHelper.SortingArraySelect(sourceArray);
            Assert.AreEqual(expectedArray, sourceArray);
        }

        [Test]
        public void SortingArraySelect_WhenArrayIsNull_ShouldArgumentNullExeption()
        {
            int[] arr = null;
            try
            {
                OneDimensionalArraysHelper.SortingArraySelect(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null. (Parameter 'Array is null!')", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
