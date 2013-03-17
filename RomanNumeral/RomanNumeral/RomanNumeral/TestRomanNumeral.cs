using NUnit.Framework;

namespace RomanNumeral
{
    [TestFixture]
    public class TestRomanNumeral
    {
        [Test]
        public void Given_1_When_GenerateCalled_ShouldReturnI()
        {
            var romanNumeral = new RomanNumeral();
            string generatedNumber = romanNumeral.GenerateRomanNumber(1);
            const string expectedRomanNumber = "I";
            Assert.That(generatedNumber, Is.EqualTo(expectedRomanNumber));
        }

        [Test]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(18, "XVIII")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(34, "XXXIV")]
        [TestCase(44, "XLIV")]
        [TestCase(58, "LVIII")]
        [TestCase(93, "XCIII")]
        [TestCase(99, "XCIX")]
        [TestCase(199, "CXCIX")]
        [TestCase(342, "CCCXLII")]
        [TestCase(479, "CDLXXIX")]
        [TestCase(572, "DLXXII")]
        [TestCase(966, "CMLXVI")]
        [TestCase(1463, "MCDLXIII")]
        [TestCase(3999, "MMMCMXCIX")]
        public void Given_Number_When_GenerateCalled_ShouldReturnExpectedRomanNumber(int number,
                                                                                     string expectedRomanNumber)
        {
            var romanNumeral = new RomanNumeral();
            string generatedNumber = romanNumeral.GenerateRomanNumber(number);
            Assert.That(generatedNumber, Is.EqualTo(expectedRomanNumber));
        }
    }
}