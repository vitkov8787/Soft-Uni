namespace _2.Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 or 3, or 6, or 7, or 10 with %
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case int n when num % 10 == 0:
                    Console.WriteLine($"The number is divisible by 10");
                    break;
                case int n when num % 7 == 0:
                    Console.WriteLine($"The number is divisible by 7");
                    break;
                case int n when num % 6 == 0:
                    Console.WriteLine($"The number is divisible by 6");
                    break;
                case int n when num % 3 == 0:
                    Console.WriteLine($"The number is divisible by 3");
                    break;
                case int n when num % 2 == 0:
                    Console.WriteLine($"The number is divisible by 2");
                    break;
                default: Console.WriteLine("Not divisible");
                    break;
            }
        }
    }
}