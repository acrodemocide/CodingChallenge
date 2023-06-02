using CodingChallenges;

namespace CodingChallengeTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private CodingChallenge _codingChallenge;

        [TestInitialize]
        public void Initialize()
        {
            _codingChallenge = new CodingChallenge();
        }

        [TestMethod]
        public void TestSpecificNumbers()
        {
            var fizz = "Fizz";
            var buzz = "Buzz";
            var fizzBuzz = fizz + buzz;

            var result = _codingChallenge.FizzBuzz();
            Assert.IsNotNull(result);
            Assert.AreEqual(result[3], fizz);
            Assert.AreEqual(result[5], buzz);
            Assert.AreEqual(result[9], fizz);
            Assert.AreEqual(result[10], buzz);
            Assert.AreEqual(result[15], fizzBuzz);
            Assert.AreEqual(result[30], fizzBuzz);
        }

        [TestMethod]
        public void TestGeneralNumbers()
        {
            int[] fizzNumbers = { 3, 6, 9, 12, 18, 21, 24, 27, 33, 36, 39, 42, 48, 51, 54, 57, 63, 66, 69, 72, 78, 81, 84, 87, 93, 99 };
            int[] buzzNumbers = { 5, 10, 20, 25, 35, 40, 50, 55, 65, 70, 80, 85, 95 };
            int[] fizzBuzzNumbers = {15, 30, 45, 60, 75, 90};

            List<int> remainingNumbers = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (!fizzNumbers.Contains(i) && !buzzNumbers.Contains(i) && !fizzBuzzNumbers.Contains(i))
                {
                    remainingNumbers.Append(i);
                }
            }

            var actual = _codingChallenge.FizzBuzz();
            foreach(int n in fizzNumbers)
            {
                Assert.AreEqual(actual[n], "Fizz");
            }

            foreach(int n in buzzNumbers)
            {
                Assert.AreEqual(actual[n], "Buzz");
            }

            foreach(int n in fizzBuzzNumbers)
            {
                Assert.AreEqual(actual[n], "FizzBuzz");
            }

            foreach(int n in remainingNumbers)
            {
                Assert.AreEqual(actual[n], "");
            }
        }
    }
}
