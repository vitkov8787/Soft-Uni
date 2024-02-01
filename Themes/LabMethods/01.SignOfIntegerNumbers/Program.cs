using System.Security.Authentication.ExtendedProtection;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void PrintN(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive. ");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative. ");
            }
            else Console.WriteLine($"The number {n} is zero. ");
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintN(number);      
        }
    }
}
