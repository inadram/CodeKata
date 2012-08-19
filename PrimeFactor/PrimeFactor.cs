using System;
using System.Collections.Generic;

namespace CodeKata
{
    public class PrimeFactor
    {
        public List<int> GetPrimeFactors(int inputNumber)
        {
            var primeList = new List<int>();
            for (int divisor = 2; divisor <=Math.Sqrt(inputNumber); divisor++)
            {
                while (inputNumber%divisor==0)
                {
                    primeList.Add(divisor);
                    inputNumber /= divisor;
                }
            }
            if (inputNumber>1)
            {
                primeList.Add(inputNumber);
            }
            return primeList;
        }
    }
}