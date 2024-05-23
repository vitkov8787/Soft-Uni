// See https://aka.ms/new-console-template for more information
int quantityFood = int.Parse(Console.ReadLine());
int[] numOrers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> orders = new Queue<int>(numOrers);
System.Console.WriteLine(orders.Max());

while (orders.Count > 0 && quantityFood > 0)
{
    if (quantityFood - orders.Peek() >= 0)
    {
        quantityFood -= orders.Dequeue();
    }
    else break;
}

if (orders.Count == 0)
{
    System.Console.WriteLine("Orders complete");
}
else
{
    System.Console.WriteLine("Orders left: " + string.Join(" ", orders));
}





