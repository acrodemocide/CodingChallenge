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
    }
}