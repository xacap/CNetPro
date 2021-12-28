using LibraryHW;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestHW
{
    class LoopsHelperTest
    {
        [Test]
        public void DegreeOfNumberAToB_WhenAAndBPassed_ShouldCalculateDegree()
        {
            int actualResoult = LoopsHelper.DegreeOfNumberAtoB(2, 2);

            Assert.AreEqual(4, actualResoult);
        }

        [TestCase(10, 3)]
        [TestCase(40, 6)]
        public void SumNumbers_WhenAPassed_ShouldSumNumbers(
           int a,
           int expectedResoult)
        {
            int actualResoult = LoopsHelper.NumbersCount(a);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [TestCase(10, 5)]
        [TestCase(65, 13)]
        public void MaxDivider_WhenANotEqualsToZero_ShouldMaxDevider(
            int a,
            int expectedResoult)
        {
            int actualResoult = LoopsHelper.MaxDivider(a);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [Test]
        public void MaxDivider_WhenAEqualsToZero_ShouldArgumentExeption()
        {
            try
            {
                LoopsHelper.MaxDivider(0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equals to Zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, 22, 42)]
        [TestCase(0, 9, 7)]
        [TestCase(1, 7, 7)]
        public void SummAFromBWhichDivideBySeven_ShouldCalculateSum(
            int a,
            int b,
            int expectedResoult)
        {
            int actualResoult = LoopsHelper.SummAFromBWhichDivideBySeven(a, b);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        public void FibonacciSeries_WhenAPassed_ShouldNNumb(
            int a,
            int expectedResoult)
        {
            int actualResoult = LoopsHelper.FibonacciSeries(a);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [Test]
        public void FibonacciSeries_WhenOwerflowInt32_ShouldOverflowException()
        {
            try
            {
                LoopsHelper.FibonacciSeries(100);
            }
            catch (OverflowException ex)
            {
                Assert.AreEqual("Value Owerflow Int32!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(5, 10, 5)]
        [TestCase(24, 128, 8)]
        public void MaxCommonDevider_WhenAAndBPositiveNumbers_ShouldMaxDevider(
            int a,
            int b,
            int expectedResolt)
        {
            int actualResoult = LoopsHelper.MaxCommonDevider(a, b);
            Assert.AreEqual(expectedResolt, actualResoult);
        }

        [Test]
        public void MaxCommonDevider_WhenAOrBNegativeNumbers_ShouldArgumentException()
        {
            try
            {
                LoopsHelper.MaxCommonDevider(-5, 10);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Negative value inserted!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(0, 0)]
        [TestCase(123, 2)]
        [TestCase(123456789, 5)]
        public void GetCountOddNumbers_WhenNumberPassed_ShouldCountOddNumber(
             int a,
            int expectedResoult)
        {
            int actualResoult = LoopsHelper.GetCountOddNumbers(a);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [TestCase(5, 5)]
        [TestCase(12345, 54321)]
        public void MirroredSequence_WhenNumberPassed_ShouldMirrorNumbers(
            int a,
            int expectedResoult)
        {
            int actualResoult = LoopsHelper.MirroredSequence(a);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [TestCase(1, 1, true)]
        [TestCase(1, 2, false)]
        [TestCase(123, 3456789, true)]
        [TestCase(500, 99, false)]
        public void ChekingIdenticalNumbers_WhenAAndBPassed_ShouldFalseOrTrue(
            int a,
            int b,
            bool expectedResoult)
        {
            bool actualResoult = LoopsHelper.ChekingIdenticalNumbers(a, b);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [TestCase(0,1)]
        [TestCase(10, 0)]
        [TestCase(0, 0)]
        public void ChekingIdenticalNumbers_WhenAAndBAreEqual_ShouldArgumentException(
            int a,
            int b)
        {
            try
            {
                LoopsHelper.ChekingIdenticalNumbers(a, b);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A and B are equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
