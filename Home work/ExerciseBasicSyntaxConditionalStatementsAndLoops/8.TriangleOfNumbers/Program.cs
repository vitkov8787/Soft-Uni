namespace _8.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 1; j <= number; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write($"{j} ");
                    if (i == j)
                    Console.WriteLine("");
                }
            }
        }
    }
}