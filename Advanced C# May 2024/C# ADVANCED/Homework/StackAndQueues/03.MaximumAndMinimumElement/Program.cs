// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();
int min = int.MaxValue;
int max = int.MinValue;
for (int i = 0; i < n; i++)
{
    int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int operation = command[0];
    if (operation == 1)
    {
        stack.Push(command[1]);
    }
    else if (operation == 2 && stack.Any())
    {
        stack.Pop();
    }
    else if (operation == 3 && stack.Any())
    {
        System.Console.WriteLine(stack.Max());
    }
    else if (operation == 4 && stack.Any())
    {
        System.Console.WriteLine(stack.Min());
    }
}
System.Console.WriteLine(string.Join(", ", stack));