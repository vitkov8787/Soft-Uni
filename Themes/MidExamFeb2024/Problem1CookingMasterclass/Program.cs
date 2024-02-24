namespace Problem1CookingMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double pFlour = double.Parse(Console.ReadLine());
            double pEgg = double.Parse(Console.ReadLine());
            double pApron = double.Parse(Console.ReadLine());

            double flourPackages = students - students / 5;
            double flourCost = flourPackages * pFlour;

            double tottal = (students+Math.Ceiling(students*0.2))*pApron + (10 * pEgg)*students + flourCost;

            if (tottal <= budget)
            {
                Console.WriteLine($"Items purchased for {tottal:F2}$.");
            }
            else
            {
                double neededMoney = tottal - budget;
                Console.WriteLine($"{neededMoney:F2}$ more needed.");
            }
        }
    }
}
