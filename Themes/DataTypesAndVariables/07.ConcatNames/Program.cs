namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delemiter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delemiter}{lastName}");
        }
    }
}