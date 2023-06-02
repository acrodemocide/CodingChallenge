using CodingChallenges;

namespace CodingChallengeTests
{
    [TestClass]
    public class ReverseTests
    {
        private CodingChallenge _codingChallenge;

        public ReverseTests()
        {
            _codingChallenge = new CodingChallenge();
        }

        [TestMethod]
        public void TestEmptyString()
        {
            var actual = _codingChallenge.Reverse(string.Empty);
            Assert.AreEqual(string.Empty, actual);
        }

        [TestMethod]
        public void TestSingleCharString()
        {
            var testStr = "a";
            var actual = _codingChallenge.Reverse(testStr);
            Assert.AreEqual(testStr, actual);
        }

        [TestMethod]
        public void TestSimpleString()
        {
            var testStr = "abc";
            var actual = _codingChallenge.Reverse(testStr);
            string expected = "cba";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLongString()
        {
            var testStr = "A quantum computer is a computer that exploits quantum mechanical phenomena";
            var actual = _codingChallenge.Reverse(testStr);
            string expected = "anemonehp lacinahcem mutnauq stiolpxe taht retupmoc a si retupmoc mutnauq A";
            Assert.AreEqual(expected, actual);
        }
    }
}
