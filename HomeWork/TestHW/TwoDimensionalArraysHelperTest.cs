using NUnit.Framework;
using LibraryHW;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestHW
{
    class TwoDimensionalArraysHelperTest
    {
        [TestCaseSource("GetMaxElementCases")]

        public void GetMaxElement_WhenArrayIsFilled_ShouldReturnMaxElement(
        int[,] sourseArray,
        int expectedResoult
        )
        {
            int actualResoult  = TwoDimensionalArraysHelper.GetMaxElement(sourseArray);

            Assert.AreEqual(expectedResoult, actualResoult);
        }

        static object[] GetMaxElementCases = new[]
        {
            new object[] { new[,] { { 1 }, { 2 } }, 2 },
            new object[] { new[,] { { 1, 2 }, { 3, 4 } }, 4 },
            new object[] { new[,] { { 2, 1, 3 }, { 4, 5, 6 } }, 6 }
        };

        [TestCaseSource(nameof(ArrayIsNullAndLengthToZeroExCases))]
        public void GetMaxElement_WhenArrayNullOrLengthZero_ShouArgumentExeption(
            int[,] array)
        {
            try
            {
                TwoDimensionalArraysHelper.GetMaxElement(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is null or array length equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        static object[] ArrayIsNullAndLengthToZeroExCases = new[]
        {
            new object[] {null},
            new object[] { new int[,] { {  }, {  } } }
        };

        [TestCaseSource("GetIndexMinValueCases")]

        public void GetIndexMinValue_WhenArrayIsFilled_ShouldReturnIndexMinValue(
        int[,] sourseArray,
        int i,
        int j)

        {
            (int a, int b) = TwoDimensionalArraysHelper.GetIndexMinValue(sourseArray);

            Assert.AreEqual((i, j), (a, b));
        }

        static object[] GetIndexMinValueCases = new[]
        {
            new object[] { new[,] { { 4 }, { 1 } }, 1, 0 },
            new object[] { new[,] { { 1, 3 }, { 4, 5 } }, 0, 0 },
            new object[] { new[,] { { 2, 1, 3 }, { 4, 5, 6 } }, 0, 1 }
        };

        [TestCaseSource(nameof(ArrayIsNullAndLengthToZeroExCases))]
        public void GetIndexMinValue_WhenArrayNullOrLengthZero_ShouArgumentExeption(
            int[,] array)
        {
            try
            {
                TwoDimensionalArraysHelper.GetIndexMinValue(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is null or array length equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource("GetIndexMaxValueCases")]
        public void GetIndexMaxValue_WhenArrayIsFilled_ShouldReturnIndexMaxValue(
        int[,] sourseArray,
        int i,
        int j)

        {
            (int a, int b) = TwoDimensionalArraysHelper.GetIndexMaxValue(sourseArray);

            Assert.AreEqual((i, j), (a, b));
        }

        static object[] GetIndexMaxValueCases = new[]
        {
            new object[] { new[,] { { 4 }, { 1 } }, 0, 0 },
            new object[] { new[,] { { 1, 3 }, { 4, 5 } }, 1, 1 },
            new object[] { new[,] { { 2, 1, 3 }, { 4, 5, 6 } }, 1, 2 }
        };

        [TestCaseSource(nameof(ArrayIsNullAndLengthToZeroExCases))]
        public void GetIndexMaxValue_WhenArrayNullOrLengthZero_ShouArgumentExeption(
            int[,] array)
        {
            try
            {
                TwoDimensionalArraysHelper.GetIndexMaxValue(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is null or array length equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource("CountMaxesValueCases")]
        public void CountMaxesValue_WhenArrayNotNull_ShouldReturnCountMaxesValue(
        int[,] sourseArray,
        int i
        )
        {
            int a  = TwoDimensionalArraysHelper.CountMaxesValue(sourseArray);

            Assert.AreEqual(i, a);
        }

        static object[] CountMaxesValueCases = new[]
        {
            new object[] { new int[,] { {  }, {  } }, 0 },
            new object[] { new[,] { { 4 }, { 1 } }, 1 },
            new object[] { new[,] { { 1, 3 }, { 4, 5 } }, 1 },
            new object[] { new[,] { { 2, 1, 3 }, { 4, 5, 6 } }, 1 },
            new object[] { new[,] { { 71, 56, 78, 18 }, { 45, 6, 53, 66 }, { 8, 29, 71, 33 }, { 22, 77, 88, 44 } }, 4 }
        };

        [Test]
        public void CountMaxesValue_WhenArrayIsNull_ShouldArgumentNullException()
        {
            int[,] arr = null;
            try
            {
                TwoDimensionalArraysHelper.CountMaxesValue(arr);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Value cannot be null. (Parameter 'Array is null!')", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource("DiagonalReflectionCases")]
        public void DiagonalReflection_WhenArrayNotNull_ShouldDiagonalReflectArray(
        int[,] sourseArray,
        int[,] expectedArray
        )
        {
            TwoDimensionalArraysHelper.DiagonalReflection(sourseArray);

            Assert.AreEqual(expectedArray, sourseArray);
        }

        static object[] DiagonalReflectionCases = new[]
        {
            new object[] { new[,] { { 1, 2 }, { 3, 4 } }, new [,] { { 1, 3 }, { 2, 4 } } },
            new object[] { new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, 
                           new[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } } }
        };


        [TestCaseSource(nameof(ArrayIsNullAndGetLengthsNoEqual))]
        public void DiagonalReflection_WhenArrayNullOrLengthZero_ShouArgumentExeption(
            int[,] array)
        {
            try
            {
                TwoDimensionalArraysHelper.DiagonalReflection(array);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is null or GetLengths no equal!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
        static object[] ArrayIsNullAndGetLengthsNoEqual = new[]
        {
            new object[] {null},
            new object[] { new int[,] { {  }, {  } } },
            new object[] { new[,] { { 1 }, { 2 } } },
            new object[] { new[,] { { 1, 2, 3 }, { 4, 5, 6 } } }
        };
    }
}
