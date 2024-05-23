Stack<char> stack = new Stack<char>();
string input = Console.ReadLine();
bool flag = true;

foreach (var item in input)
{
    if (item is '(' or '[' or '{')
    {
        stack.Push(item);
        continue;
    }
    if (stack.Count > 0)
    {
        if (item == ')' && stack.Peek() == '(')
        {
            stack.Pop();

        }
        else if (item == ']' && stack.Peek() == '[')
        {
            stack.Pop();
        }
        else if (item == '}' && stack.Peek() == '{')
        {
            stack.Pop();
        }
        else
        {
            flag = false;
            break;
        }
    }
    else
    {
        flag = false;
        break;
    }
}
if (!flag)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}