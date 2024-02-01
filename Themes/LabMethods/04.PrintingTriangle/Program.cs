namespace _04.PrintingTriangle
{
    internal class Program
    {
        private static void Rows(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Rows(i);
                Console.WriteLine("");
            }
            for (int i = input - 1; i >= 0; i--)
            {
                Rows(i);
                Console.WriteLine("");    
            }
        }
    }
}
