namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char firstChar = (char)('a' + i);

                for (int j = 0; j < n; j++)
                {
                    char secChar = (char)('a' + j);

                    for (int k = 0; k < n; k++)
                    {
                        char lastChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secChar}{lastChar}");
                    }
                }
            }
        }
    }
}
