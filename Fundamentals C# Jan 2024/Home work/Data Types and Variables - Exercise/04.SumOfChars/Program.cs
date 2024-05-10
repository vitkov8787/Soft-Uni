using System.Threading.Channels;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <number; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += (int)letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
        
    }
}
