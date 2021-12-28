using LibraryHW;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestHW
{
    class ConditionalOperatorsHelperTest
    {

        [TestCase(3, 2, 5)]
        [TestCase(3, 3, 9)]
        [TestCase(5, 7, -2)]
        public void CompareAndCalculate_WhenAAndBPassed_ShouldCalculateAAndB(
            int a,
            int b,
            int expectedResoult)
        {
            int actualResoult = ConditionalOperatorsHelper.CompareAndCalculate(a, b);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [TestCase(2, 2, 1)]
        [TestCase(-3, 3, 2)]
        [TestCase(-4, -4, 3)]
        [TestCase(5, -3, 4)]

        public void GetCoordinateQuarter_WhenXAndYPassed_ShouldNumberQuarter(
            int x,
            int y,
            int expectedResoult)
        {
            int actualResult = ConditionalOperatorsHelper.CoordinateQuarter(x, y);
            Assert.AreEqual(expectedResoult, actualResult);
        }

        [Test]
        public void GetCoordinateQuarter_WhenArgumentZero_ShouldArgumentException()
        {
            try
            {
                ConditionalOperatorsHelper.CoordinateQuarter(0, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Misses a quarter!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(3, 2, 1, 1, 2, 3)]
        [TestCase(98, 101, 16, 16, 98, 101)]
        public void IncreasingNumbers_WhenThreeNumbersPassed_ShouldIncresingThisNumbers(
            int a,
            int b,
            int c,
            int A,
            int B,
            int C)
        {
            var expectedResoult = (A, B, C);
            var actualResoult = ConditionalOperatorsHelper.IncreasingNumbers(a, b, c);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [TestCase(25, "Twenty five")]
        [TestCase(10, "Ten")]
        public void NumberInWords_WhenTwoDigitNumberPassed_ShouldPrintStringThisNumber(
            int a,
            string expectedResoult)
        {
            string actualResoult = ConditionalOperatorsHelper.NumberInWords(a);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [Test]
        public void NumberInWords_WhenNumberNotTwoDigit_ShoulArgumenException()
        {
            try
            {
                ConditionalOperatorsHelper.NumberInWords(9);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Input Erorr!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, 9, 3, -16.55, -1.45)]
        public void QuadraticEquation_ShouldResult(
            double a,
            double b,
            double c,
            double q,
            double w
            )
        {
            var expectedResoult = (q,w);
            var actualResoult = ConditionalOperatorsHelper.QuadraticEquation(a,b,c);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [Test]
        public void QuadraticEquation_WhenNoSolution_ShoulArgumenException()
        {
            try
            {
                ConditionalOperatorsHelper.QuadraticEquation(0, 66, 77);
                ConditionalOperatorsHelper.QuadraticEquation(55, 66, 77);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The equation has no solution!", ex.Message);
                Assert.Pass();
            }
           
            Assert.Fail();
        }

        [Test]
        public void QuadraticEquation_WhenAEqualToZero_ShoulArgumenException()
        {
            try
            {
                ConditionalOperatorsHelper.QuadraticEquation(0, 66, 77);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equals to Zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }


}
