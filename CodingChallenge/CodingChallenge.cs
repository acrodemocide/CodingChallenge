using System.Text;

namespace CodingChallenges
{
    public class CodingChallenge
    {
        public int Fibbonacci(int n)
        {
            if (n < 0)
            {
                throw new Exception("Cannot accept negative numbers");
            }

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibbonacci(n - 1) + Fibbonacci(n - 2);
            }
        }

        public Dictionary<int, string> FizzBuzz()
        {
            List<int> numbers = new List<int>();
            for(int i = 1; i < 101; i++)
            {
                numbers.Add(i);
            }

            Dictionary<int, string> result = new Dictionary<int, string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                if (numbers[i] % 3 == 0)
                {
                    sb.Append("Fizz");
                }
                if (numbers[i] % 5 == 0)
                {
                    sb.Append("Buzz");
                }
                result.Add(numbers[i], sb.ToString());
            }
            return result;
        }
    }
}