namespace _4.Backin30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int minutes = min + 30;
            if (minutes > 60)
            {
                minutes -= 60;
                hours += 1;
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            if (minutes < 10) {
                Console.WriteLine($"{hours}:0{minutes}");
            }else
            Console.WriteLine($"{hours}:{minutes}");
        }
    }
}