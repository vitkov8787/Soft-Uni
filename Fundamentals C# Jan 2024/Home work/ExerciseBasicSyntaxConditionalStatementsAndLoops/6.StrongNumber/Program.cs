namespace _6.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1! + 4! + 5! =
            //1 × 1 + 4 × 3 × 2 × 1
            //+ 5 × 4 × 3 × 2 × 1
            //= 1 + 24 + 120 = 145
            
            int input = int.Parse(Console.ReadLine());
            int number = input;
            int sum = 0;
            while (input > 0)
            {
                int factorial = 1;   
                int digit = input % 10;
                //here we change the input to be =/10
                input = input / 10;//<=============== for this whe need number = input to store original
                //Console.WriteLine(digit);
                
                for (int i = 1;  i <= digit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }
            //Console.WriteLine(sum);
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}