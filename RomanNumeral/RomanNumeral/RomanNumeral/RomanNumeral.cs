using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral
{
    public static class Roman
    {
        public static IEnumerable<KeyValuePair<int, string>> Symbols()
        {
            var romanSymbols = new Dictionary<int, string>();
            romanSymbols.Add(1, "I");
            romanSymbols.Add(4, "IV");
            romanSymbols.Add(5, "V");
            romanSymbols.Add(9, "IX");
            romanSymbols.Add(10, "X");
            romanSymbols.Add(40, "XL");
            romanSymbols.Add(50, "L");
            romanSymbols.Add(90, "XC");
            romanSymbols.Add(100, "C");
            romanSymbols.Add(400, "CD");
            romanSymbols.Add(500, "D");
            romanSymbols.Add(900, "CM");
            romanSymbols.Add(1000, "M");
            var keyValuePairs = romanSymbols.OrderByDescending(x => x.Key);
            return keyValuePairs;
        }
    }

    public class RomanNumeral : IRomanNumeralGenerator
    {
        public string GenerateRomanNumber(int number)
        {
            string converToRomanNumber = number.ConverToRomanNumber(); ;
            return converToRomanNumber;
        }
    }
}