namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double britishPound=double.Parse(Console.ReadLine());
            Console.WriteLine($"{britishPound * 1.31:F3}");
        }
    }
}