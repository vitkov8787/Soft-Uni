int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//numbers element to insert in queue
int n = input[0];
//numbers element to delete from queue
int s = input[1];
//element to search in queue
int x = input[2];
//new queue
Queue<int> queue = new Queue<int>();
int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < n; i++)
{
    queue.Enqueue(elements[i]);
}
for (int i = 0; i < s; i++)
{
    queue.Dequeue();
}

if (queue.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    int min = int.MaxValue;

    foreach (var item in queue)
    {
        if (item < min)
            min = item;
    }

    if (queue.Count > 0)
    {
        Console.WriteLine(min);
    }
    else
    {
        Console.WriteLine(0);
    }
}