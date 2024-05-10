namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int digits = 0;
                int x = i;
                while (x !=0)
                {
                    digits += x % 10;
                    x = x / 10;
                }
                if (digits == 5 || digits == 7 || digits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
