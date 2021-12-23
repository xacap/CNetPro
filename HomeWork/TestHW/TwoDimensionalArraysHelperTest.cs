using NUnit.Framework;
using LibraryHW;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestHW
{
    class TwoDimensionalArraysHelperTest
    {
        [TestCaseSource("MinCases")]

        public void GetIndexMinValue_WhenArrayIsFilled_ShouldReturnIndexMinValue(
        int[,] sourseArray,
        int i, 
        int j)

        {
            (int a, int b) = TwoDimensionalArraysHelper.GetIndexMinValue(sourseArray);

            Assert.AreEqual((i, j), (a,b));
        }

        static object[] MinCases = new[]
        {
            new object[] { new[,] { { 2, 1 ,3 }, { 4 ,5 ,6 } }, 0,1 }
        };





    }
}
