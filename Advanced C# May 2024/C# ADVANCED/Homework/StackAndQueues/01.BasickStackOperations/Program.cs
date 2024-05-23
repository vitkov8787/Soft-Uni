int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//numbers push in stack
int n = input[0];
// numbers to pop from stack
int s = input[1];
// element to look for in  to stak
int x = input[2];

var stack = new Stack<int>();


int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < n; i++)
{
    stack.Push(elements[i]);
}
for (int i = 0; i < s; i++)
{
    stack.Pop();

}
if (stack.Contains(x))
{
    System.Console.WriteLine("true");
}

else
{
    int min = int.MaxValue;

    foreach (var item in stack)
    {
        if (item < min)
            min = item;
    }

    if (stack.Count > 0)
    {
        Console.WriteLine(min);
    }
    else
    {
        Console.WriteLine(0);
    }
}