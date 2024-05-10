namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengersInWagon = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                passengersInWagon[i]= int.Parse(Console.ReadLine());
                sum += passengersInWagon[i];
            }
            foreach (var item in passengersInWagon)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine($"\n{sum}");
        }
    }
}
