using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger value = 0;
            BigInteger result = 0;
            int one = 0, two = 0, three = 0;
            int nSnowballs = int.Parse(Console.ReadLine());
            for (int i = 0; i < nSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (value > result)
                {
                    result = value;
                    one = snowballSnow;
                    two = snowballTime;
                    three = snowballQuality;
                }
            }
            Console.WriteLine($"{one} : {two} = {result} ({three})");
        }
    }
}
