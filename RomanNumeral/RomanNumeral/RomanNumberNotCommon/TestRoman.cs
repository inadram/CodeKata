using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RomanNumberNotCommon
{
    [TestFixture]
    public class TestRoman
    {
        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(90, "XC")]
        [TestCase(100, "C")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]
        public void When_RomanSymbolsCalled_Then_ShouldReturnExpectedRomanSymbols(int key, string value)
        {
            IEnumerable<KeyValuePair<int, string>> keyValuePairs = Roman.Symbols();
            var expectedkeyValuePairs = new KeyValuePair<int, string>(key, value);
            Assert.That(keyValuePairs.Contains(expectedkeyValuePairs));
        }
        [Test]
        public void When_RomanSymbolsCalled_Then_ShouldReturnIAsLastMember()
        {
            IEnumerable<KeyValuePair<int, string>> keyValuePairs = Roman.Symbols();
            var expectedkeyValuePairs = new KeyValuePair<int, string>(1, "I");
            Assert.That(keyValuePairs.ToList().Last(),Is.EqualTo(expectedkeyValuePairs));
        }
    }
}