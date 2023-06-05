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
        public void Test2()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(2);
            var expected = "II";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(3);
            var expected = "III";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(4);
            var expected = "IV";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(5);
            var expected = "V";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(6);
            var expected = "VI";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test7()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(7);
            var expected = "VII";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test8()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(8);
            var expected = "VIII";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test9()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(9);
            var expected = "IX";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test10()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(10);
            var expected = "X";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test11()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(11);
            var expected = "XI";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test30()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(30);
            var expected = "XXX";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test40()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(40);
            var expected = "XL";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test50()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(50);
            var expected = "L";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test60()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(60);
            var expected = "LX";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test80()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(80);
            var expected = "LXXX";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test90()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(90);
            var expected = "XC";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test100()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(100);
            var expected = "C";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test110()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(110);
            var expected = "CX";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test300()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(300);
            var expected = "CCC";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test400()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(400);
            var expected = "CD";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test500()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(500);
            var expected = "D";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test600()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(600);
            var expected = "DC";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test800()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(800);
            var expected = "DCCC";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test900()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(900);
            var expected = "CM";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1000()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(1000);
            var expected = "M";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1100()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(1100);
            var expected = "MC";
            Assert.AreEqual(expected, actual);
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

        [TestMethod]
        public void Test528()
        {
            var actual = _codingChallenge.ConvertArabicToRomanNumerals(528);
            var expected = "DXXVIII";
            Assert.AreEqual(expected, actual);
        }
    }
}
