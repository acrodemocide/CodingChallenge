using System.Text;

namespace CodingChallenges
{
    public class CodingChallenge
    {
        public string Reverse(string str)
        {
            // Return a reversed string of the passed in string.
            // If "abc" is passed in, then this should return "cba."
            // If an empty string is passed in, return the empty string.
            // If a single character string is passed in, return that same string (i.e.: "a" reversed is "a").
            // Every other string should be a reverse of the string passed in.
            // You cannot use str.Reverse -- an algorithm to reverse the string should be implemented here.
            throw new NotImplementedException();
        }

        public int Fibbonacci(int n)
        {
            // Fill out logic in this function to return the nth number of the Fibbonacci sequence.
            // Negative number results in exception with message: "Cannot accept negative numbers");
            // f(0) = 0
            // f(1) = 1
            // f(n) = associated fibbonacci number (for our testing, we won't do anything greater than 45).
            throw new NotImplementedException();
        }

        public Dictionary<int, string> FizzBuzz()
        {
            // Create and return a dictionary with keys 1-100
            // If the number is divisible by 3, then the associated string will be "Fizz"
            // If the number is divisible by 5, then the associated string will be "Buzz"
            // If the number is divisible by both 3 and 5, then the associated string will be "FizzBuzz"
            // If the number is divisible by neither then the string the associated string will be empty ("")
            //
            // For example, the dictionary returned will have the following:
            // result[2] = ""
            // result[3] = "Fizz"
            // result[5] = "Buzz"
            // result[15] = "FizzBuzz"
            throw new NotImplementedException();
        }
    }
}