using System;
using System.Text;

namespace RomanNumberNotCommon
{
    public interface IRomanNumeralGenerator
    {
        String GenerateRomanNumber(int number);
    }

    public class RomanNumeral : IRomanNumeralGenerator
    {
        public string GenerateRomanNumber(int number)
        {
            string converToRomanNumber = ConverToRomanNumber(number);
            return converToRomanNumber;
        }

        private string ConverToRomanNumber(int number)
        {
            var romanNumber = new StringBuilder();
            foreach (var romanSymbol in Roman.Symbols())
            {
                while (number >= romanSymbol.Key)
                {
                    romanNumber.Append(romanSymbol.Value);
                    number -= romanSymbol.Key;
                }
            }

            return romanNumber.ToString();
        }
    }
}