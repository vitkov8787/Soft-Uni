// See https://aka.ms/new-console-template for more information

var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//for loopa opravi

Stack<int> stack = new Stack<int>();
foreach (var item in input)
{
    stack.Push(item);
}
var command = Console.ReadLine().ToLower();

while (command != "end")
{
    var tokens = command.Split();

    if (tokens[0] == "add")
    {
        //push in stack
        stack.Push(int.Parse(tokens[1]));
        stack.Push(int.Parse(tokens[2]));

    }
    else
    {
        var n = int.Parse(tokens[1]);
        if (stack.Count >= n)
        {
            for (int i = 0; i < n; i++)
            {
                stack.Pop();
            }
        }
    }
    command = Console.ReadLine().ToLower();
}
Console.WriteLine($"Sum: {stack.Sum()}");
