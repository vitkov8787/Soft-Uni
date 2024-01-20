namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metter = double.Parse(Console.ReadLine());
            Console.WriteLine($"{metter/1000:F2}");
        }
    }
}