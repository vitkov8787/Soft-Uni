// See https://aka.ms/new-console-template for more information

string? input;
Queue<string> queue = new Queue<string>();
while ((input = Console.ReadLine()) != "End")
{
    if (input == "Paid")
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
    else
    {
        queue.Enqueue(input);
    }
}
System.Console.WriteLine($"{queue.Count} people remaining.");
