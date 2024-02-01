namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int digit = n % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int digit = n % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int n)
        {
            int sumOfEvens = GetSumOfEvenDigits(n);
            int sumOfOdds = GetSumOfOddDigits(n);
            return sumOfEvens * sumOfOdds;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int n = Math.Abs(a);
            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }
    }
}
