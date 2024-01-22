namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            while (people > 0 ) {
                people=people - capacity;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
