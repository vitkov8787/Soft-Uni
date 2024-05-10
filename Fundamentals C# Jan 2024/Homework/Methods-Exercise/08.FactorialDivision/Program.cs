using System;
using System.Numerics;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static long CalculateFactorial(int number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            long a = CalculateFactorial(num1);
            long b = CalculateFactorial(num2);

            decimal result = (decimal)a / (decimal)b;
            Console.WriteLine($"{result:F2}");
        }
    }
}
