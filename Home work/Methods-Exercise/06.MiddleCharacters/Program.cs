namespace _06.MiddleCharacters
{
    internal class Program
    {
        static string CharMiddle(string input) {
            int midlle = input.Length / 2;
            if (input.Length %2==0)
            {
                return $"{input[midlle-1]}{input[midlle]}";
            }else
            return input[midlle].ToString();
        }
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            Console.WriteLine(CharMiddle(input));
        }
    }
}
