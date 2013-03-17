using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PrimeFactor
{
    [TestFixture]
    public class TestPrimeFactor
    {
        [Test]
        public void Given_1_When_GetPrimeFactorCalled_Then_ShouldReturnEmptyList()
        {
            var primeFactorGenerator=new PrimeFactorGenerator();
            var primeFactorList=primeFactorGenerator.GetAllPrimeFactors(1);
            Assert.That(primeFactorList,Is.EqualTo(new List<int>()));
        }

        [TestCase(1,new int[]{})]
        [TestCase(2,new int[]{2})]
        [TestCase(3,new int[]{3})]
        [TestCase(4,new int[]{2,2})]
        [TestCase(5,new int[]{5})]
        [TestCase(6,new int[]{2,3})]
        [TestCase(7,new int[]{7})]
        [TestCase(8,new int[]{2,2,2})]
        [TestCase(9,new int[]{3,3})]
        [TestCase(11,new int[]{11})]
        [TestCase(27,new int[]{3,3,3})]
        [TestCase(2*3*3*3*7*11*19*23, new int[] { 2, 3, 3, 3, 7, 11, 19, 23 })]
        public void Given_2_When_GetPrimeFactorCalled_Then_ShouldReturnListThatContains2(int number, int[] expectedList)
        {
            var primeFactorGenerator = new PrimeFactorGenerator();
            var primeFactorList = primeFactorGenerator.GetAllPrimeFactors(number);
            Assert.That(primeFactorList, Is.EqualTo(expectedList));
        }
    }

    public class PrimeFactorGenerator
    {
        public List<int> GetAllPrimeFactors(int number)
        {
            var primeFactorList = new List<int>();
                for (int divisor = 2; divisor <= number; divisor++)
                {
                    while(number%divisor==0)
                    {
                        primeFactorList.Add(divisor);
                        number /= divisor;
                    }
                }

         return primeFactorList;
        }
    }
}
