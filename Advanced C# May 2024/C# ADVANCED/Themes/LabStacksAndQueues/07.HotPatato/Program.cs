// See https://aka.ms/new-console-template for more information
List<string> names = Console.ReadLine().Split().ToList();
int number = int.Parse(Console.ReadLine());
Queue<string> queue = new Queue<string>(names);
while (queue.Count > 1)
{
    for (int i = 1; i < number; i++)
    {
        // save the first name
        string firstName = queue.Dequeue();
        // add the first name to the end of the queue
        queue.Enqueue(firstName);
    }
    // the first name removed from the queue is displayed
    Console.WriteLine($"Removed {queue.Dequeue()}");
}
//the loop continues until there is only one name remaining in the queue
Console.WriteLine($"Last is {queue.Dequeue()}");