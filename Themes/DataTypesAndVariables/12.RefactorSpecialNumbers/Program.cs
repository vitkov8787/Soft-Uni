namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
          
            for (int i = 1; i <=input; i++)
            {
                int x = 0;
                int number = i;
                while (number > 0)
                {
                    x += number % 10;
                    number = number / 10;
                }
                bool isSpecialNum = (x == 5 || x == 7 || x == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNum);
            }
        }
    }
}