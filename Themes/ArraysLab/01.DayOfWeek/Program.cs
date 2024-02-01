namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (input > 7|| input<=0)
            {
                Console.WriteLine("Invalid day!");
            }
            else Console.WriteLine(days[input - 1]);
        }
    }
}
