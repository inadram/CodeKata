using System.Text;

namespace RomanNumeral
{
    public static class IntegerExtention
    {
        public static string ConverToRomanNumber(this int number)
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