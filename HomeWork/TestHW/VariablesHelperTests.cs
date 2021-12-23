using LibraryHW;
using NUnit.Framework;
using System;

namespace TestHW
{
    public class VariablesHelperTests
    {
        [TestCase(2, 3, 19)]
        public void CalculateEqantion_WhenANotEqualToB_ShouldCalculateEquation(
            double a,
            double b,
            double expectedResult)
        {
            double actialresult = VariablesHelper.CalculateEqantion(a, b);
            Assert.AreEqual(expectedResult, actialresult);
        }

        [Test]
        public void CalculateEqantion_WhenANotEqualToB_ShouldTrowArgumentException()
        {
            try
            {
                VariablesHelper.CalculateEqantion(1, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equal to B!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase("aaa", "bbb", "bbbaaa")]
        public void SwichStringAAndB_WhenAAndBPassed_ShouldBAndA(
            string a,
            string b,
            string expectedResoult
            )
        {
            string actualResoult = VariablesHelper.SwichString("aaa", "bbb");
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [TestCase(9, 2, 4, 1)]
        public void DivideAndGetRemainder_WhenBNotEqualToZero_ShouldResoultAndRemaider(
            int a,
            int b,
            int c,
            int d)
        {
            var expectedResoult = (c, d);
            var actualResoult = VariablesHelper.DivideAndGetRemainder(a, b);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [Test]
        public void DivideAndGetRemainder_WhenBEqualToZero_ShouldTrowArgumentException()
        {
            try
            {
                VariablesHelper.DivideAndGetRemainder(1, 0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("B equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(3, 4, 10, 2)]
        public void LinearEquation_WhenAllValueNotEqualToZero_ShouldValueX(
            double a,
            double b,
            double c,
            double expectedResoult
            )
        {
            double actualResoult = VariablesHelper.LinearEquation(a, b, c);
            Assert.AreEqual(expectedResoult, actualResoult);
        }

        [Test]
        public void LinearEquation_WhenValueEqualToZero_ShouldTrowArgumentException()
        {
            try
            {
                VariablesHelper.LinearEquation(0, 4, 10);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Input Error!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, 1, -3, 4, -0.6, 2.2)]
        [TestCase(2.2, 3.3, 4.4, 5.5 , 1, 1.1)]
        public void PrintEqationYEqualsAXPlusB_WhenX1NotEqualX2_ShouldValuesAAndB(
            double x1, 
            double y1, 
            double x2, 
            double y2, 
            double A, 
            double B
            )
        {
            var expectedResoult = (A, B);
            var actualResult =  VariablesHelper.PrintEqationYEqualsAXPlusB(x1,y1,x2,y2);
            Assert.AreEqual(expectedResoult, actualResult);
        }

        [Test]
        public void PrintEqationYEqualsAXPlusB_WhenX1EqualX2_ShoulTrowDivideByZeroException()
        {
            try
            {
                VariablesHelper.PrintEqationYEqualsAXPlusB(2, 1, 2, 3);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("x1 equal to x2!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}