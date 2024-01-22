namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int amountColect = 0;
            while (startingYield > 99) {
                days++;
                amountColect += startingYield;
                startingYield -= 10;
            }
            if (amountColect > 25)
            {
                amountColect =amountColect-(days+1)* 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(amountColect);
        }
    }
}
