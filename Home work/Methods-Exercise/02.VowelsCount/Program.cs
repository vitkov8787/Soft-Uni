namespace _02.VowelsCount
{
    internal class Program
    {
        static int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char item in input)
            {
                if (vowels.Contains(item))
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(CountVowels(input));
        }
    }
}
