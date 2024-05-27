namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(input.Length);

            //reverse the input and put it in the stack s
            // Input expression: 2 + 5 + 10 - 2 - 1
            //Stack: 1 - 2 - 10 + 5 + 2
            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            //take out the last num in stack
            int result = int.Parse(stack.Pop());


            while (stack.Count > 0)
            {
                //out first oppertor
                string op = stack.Pop();
                //out next num
                int nextNum = int.Parse(stack.Pop());

                if (op == "+")
                {
                    result += nextNum;
                }
                else if (op == "-")
                {
                    result -= nextNum;
                }
                else throw new Exception("Invalid operation!");
            }
            System.Console.WriteLine(result);
        }
    }
}
