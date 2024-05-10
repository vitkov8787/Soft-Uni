namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            result = ((a+b)/c)*d;
            Console.WriteLine(result);
        }
    }
}
