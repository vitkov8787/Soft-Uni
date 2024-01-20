namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char x = char.Parse(Console.ReadLine());
            if (char.IsUpper(x))
            {
                Console.WriteLine("upper-case");
            }else Console.WriteLine("lower-case");
        }
    }
}