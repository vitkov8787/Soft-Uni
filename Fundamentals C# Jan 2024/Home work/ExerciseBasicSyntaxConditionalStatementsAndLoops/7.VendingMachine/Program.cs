namespace _7.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0.1, 0.2, 0.5, 1 and 2
            double coins = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start") break;
                double money = double.Parse(input);//<======
                if (money != 0.1 && money != 0.2 &&
                    money != 0.5 && money != 1 && money != 2)
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                else coins += money;
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine($"Change: {coins:f2}"); break;
                }
                string product = input;
                double price = 0;
                switch (product)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }
                if (coins >= price)
                {

                    coins -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }

        }
    }
}