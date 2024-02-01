namespace _05.Orders
{
    internal class Program
    {
        static void PriceOfOrder(string product, int amount)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{(1.5 * amount):F2}");
                    break;
                case "water":
                    Console.WriteLine($"{(1.0 * amount):F2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(1.4 * amount):F2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(2.0 * amount):F2}");
                    break;
            }
        }
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            PriceOfOrder(product,amount);
        }
    }
}
