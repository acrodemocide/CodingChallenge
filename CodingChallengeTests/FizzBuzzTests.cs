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
            var fizz = "Fizz";
            var buzz = "Buzz";
            var fizzBuzz = fizz + buzz;

            var result = _codingChallenge.FizzBuzz();

            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Assert.AreEqual(result[i], fizzBuzz);
                }
                else if (i % 3 == 0)
                {
                    Assert.AreEqual(result[i], fizz);
                }
                else if (i % 5 == 0)
                {
                    Assert.AreEqual(result[i], buzz);
                }
                else
                {
                    Assert.AreEqual(result[i], string.Empty);
                }
            }
        }
    }
}
