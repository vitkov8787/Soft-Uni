namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
       //((daysInMonth * capsulesCount) * pricePerCapsule)
            int n = int.Parse(Console.ReadLine());
            double tottalP = 0;
            for (int i = 0; i < n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double price = (daysInMonth * capsulesCount) * pricePerCapsule;
                tottalP += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            Console.WriteLine($"Total: ${tottalP:F2}");
        }
    }
}