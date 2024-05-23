string[] words = Console.ReadLine().Split(", ").ToArray();
Queue<string> queue = new Queue<string>(words);

while (queue.Any())
{
    string[] commands = Console.ReadLine().Split(new char[] { ' ' }, 2);

    string command = commands[0];
    if (command == "Play")
    {
        queue.Dequeue();
    }
    else if (command == "Add")
    {
        string song = commands[1];
        if (!queue.Contains(song))
        {
            queue.Enqueue(song);
        }
        else
        {
            Console.WriteLine($"{song} is already contained!");
        }
    }
    else if (command == "Show")
    {
        Console.WriteLine(string.Join(", ", queue));
    }
}
if (queue.Count == 0)
{
    System.Console.WriteLine("No more songs!");
}