using CodingChallenges;

namespace CodingChallengeTests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        private CodingChallenge _codingChallenge;

        public RomanNumeralsTests()
        {
            _codingChallenge = new CodingChallenge();
        }

        [TestMethod]
        public void TestNegativeNumber()
        {
            try
            {
                _codingChallenge.ConvertArabicToRomanNumerals(-5);
                Assert.Fail("Should not pass here");
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.Message, "Number outside of range.");
            }
        }

        [TestMethod]
        public void TestZero()
        {
            try
            {
                _codingChallenge.ConvertArabicToRomanNumerals(0);
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.Message, "Number outside of range.");
            }
        }

        [TestMethod]
        public void TestLowerBound()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(1);
            var expected = "I";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpperBound()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(3999);
            var expected = "MMMCMXCIX";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOverUpperBound()
        {
            try
            {
                _codingChallenge.ConvertArabicToRomanNumerals(4000);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Number outside of range.");
            }
        }

        [TestMethod]
        public void Test1666()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(1666);
            var expected = "MDCLXVI";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1990()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(1990);
            var expected = "MCMXC";
            Assert.AreEqual(expected, actual);
        }
    }
}
