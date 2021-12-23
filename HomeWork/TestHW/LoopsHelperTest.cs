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
    }
}
