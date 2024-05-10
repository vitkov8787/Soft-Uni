
string input = Console.ReadLine();
Stack<int> stack = new Stack<int>();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        stack.Push(i);
    }
    else if (input[i] == ')')
    {
        int startIndex = stack.Pop() + 1;
        int endIndex = i;
        string subString = input.Substring(startIndex - 1, endIndex - startIndex + 2);
        Console.WriteLine(subString);
    }
}