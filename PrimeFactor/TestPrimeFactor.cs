using System.Collections.Generic;
using NUnit.Framework;

namespace CodeKata
{
    [TestFixture]
    public class TestPrimeFactor
    {
        [TestCase(1,new int[]{})]
        [TestCase(2,new []{2})]
        [TestCase(3,new []{3})]
        [TestCase(4,new []{2,2})]
        [TestCase(5,new []{5})]
        [TestCase(6,new []{2,3})]
        [TestCase(7,new []{7})]
        [TestCase(8,new []{2,2,2})]
        [TestCase(9,new []{3,3})]
        [TestCase(10,new []{2,5})]
        [TestCase(11,new []{11})]
        [TestCase(12,new []{2,2,3})]
        [TestCase(2*17*11*19*2*5*7,new []{2,2,5,7,11,17,19})]
        [TestCase(int.MaxValue,new []{int.MaxValue}),Timeout(100)]
        public void Given_InputNumber_when_GetPrimeFactor_should_Return_ExpectedList(int inputNumber,int[] expectedList)
        {
            var primeFactor=new PrimeFactor();
            var primeList = primeFactor.GetPrimeFactors(inputNumber);
            Assert.That(primeList,Is.EqualTo(expectedList));
        }
    }
}
