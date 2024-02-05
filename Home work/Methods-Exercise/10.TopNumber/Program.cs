using System;
using System.Linq;

namespace _10.TopNumber
{
    internal class Program
    {
        static bool IsTopNumber(int number)
        {
            int sum = 0;
            bool flag = false;
            int tempNumber = number;

            while (tempNumber > 0)
            {
                int digit = tempNumber % 10;
                sum += digit;

                if (digit % 2 != 0)
                    flag = true;

                tempNumber /= 10;
            }
            return sum % 8 == 0 && flag;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                    Console.WriteLine(i);
            }
        }
    }
}
