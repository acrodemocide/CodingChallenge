using CodingChallenges;

namespace CodingChallengeTests
{
    [TestClass]
    public class FibbonacciTests
    {
        private CodingChallenge _codingChallenge;

        public FibbonacciTests()
        {
            _codingChallenge = new CodingChallenge();
        }

        [TestMethod]
        public void TestNegativeInput()
        {
            var input = -1;
            var expected = "Cannot accept negative numbers";

            try
            {
                var actual = _codingChallenge.Fibbonacci(input);
                Assert.Fail("Should not pass here");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestMethod]
        public void TestZeroInput()
        {
            var input = 0;
            var expected = 0;
            var actual = _codingChallenge.Fibbonacci(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFirstElement()
        {
            var input = 1;
            var expected = 1;
            var actual = _codingChallenge.Fibbonacci(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSecondElement()
        {
            var input = 2;
            var expected = 1;
            var actual = _codingChallenge.Fibbonacci(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThirdElement()
        {
            var input = 3;
            var expected = 2;
            var actual = _codingChallenge.Fibbonacci(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFifteenthElement()
        {
            var input = 15;
            var expected = 610;
            var actual = _codingChallenge.Fibbonacci(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFortyFifthElement()
        {
            var input = 45;
            var expected = 1134903170;
            var actual = _codingChallenge.Fibbonacci(input);
            Assert.AreEqual(expected, actual);
        }
    }
}