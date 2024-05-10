namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int waterIn = 0;
            for (int i = 0; i < nLines; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                waterIn += litters;
                if (waterIn > 255)
                {
                    waterIn -= litters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(waterIn);
        }
    }
}
