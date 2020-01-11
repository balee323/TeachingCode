
using NUnit.Framework;

namespace HexadecimalConverter
{
    [TestFixture]
    class Tests
    {

       


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Decimal_Case1_convertedCorrectly_ValuesHexValues()
        {
            var value = HexadecimalConvert.ConvertHexToDecimal("1");

            Assert.AreEqual(1, value);
        }

        [Test]
        public void Decimal_Case2_convertedCorrectly_ValuesHexValues()
        {
            var value = HexadecimalConvert.ConvertHexToDecimal("5");

            Assert.AreEqual(5, value);
        }

        [Test]
        public void Decimal_Case3_convertedCorrectly_ValuesHexValues()
        {
            var value = HexadecimalConvert.ConvertHexToDecimal("A0");

            Assert.AreEqual(160, value);
        }

        [Test]
        public void Decimal_Case4_convertedCorrectly_ValuesHexValues()
        {
            var value = HexadecimalConvert.ConvertHexToDecimal("AA0");

            Assert.AreEqual(2720, value);
        }

        [Test]
        public void Decimal_Case5_convertedCorrectly_ValuesHexValues()
        {
            var value = HexadecimalConvert.ConvertHexToDecimal("F0");

            Assert.AreEqual(240, value);
        }


        [Test]
        public void Decimal_Case6_convertedCorrectly_ValuesHexValues()
        {
            var value = HexadecimalConvert.ConvertHexToDecimal("AAF0");

            Assert.AreEqual(43760, value);
        }


        [Test]
        public void Decimal_Case7_convertedCorrectly_ValuesHexValues()
        {
            var value = HexadecimalConvert.ConvertHexToDecimal("A7F3");

            Assert.AreEqual(42995, value);
        }


        [Test]
        public void Hexadecimal_Case1_convertedCorrectly_DecimalValues()
        {
            var value = HexadecimalConvert.ConvertToHexaDecimal(90);

            Assert.AreEqual("5A", value);
        }

        [Test]
        public void Hexadecimal_Case2_convertedCorrectly_DecimalValues()
        {
            var value = HexadecimalConvert.ConvertToHexaDecimal(190);

            Assert.AreEqual("BE", value);
        }


        [Test]
        public void Hexadecimal_Case3_convertedCorrectly_DecimalValues()
        {
            var value = HexadecimalConvert.ConvertToHexaDecimal(8500);

            Assert.AreEqual("2134", value);
        }


    }
}
