namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToCharArray().ToList();
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                stack.Push(c);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
