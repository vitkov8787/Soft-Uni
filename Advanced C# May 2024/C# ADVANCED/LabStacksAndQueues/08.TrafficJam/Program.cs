// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
string? input = Console.ReadLine();
Queue<string> queue = new Queue<string>();
int count = 0;
while (input != "end")
{
    if (input != "green")
    {
        queue.Enqueue(input);
    }
    else
    {
        for (int i = 0; i < n; i++)
        {
            if (queue.Count > 0)
            {
                string car = queue.Dequeue();
                System.Console.WriteLine($"{car} passed!");
                count++;
            }
        }
    }
    input = Console.ReadLine(); // Read the next input here

}
Console.WriteLine($"{count} cars passed the crossroads.");
