namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split();
            var words = inputWords.Where(x=>x.Length%2==0).ToArray();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
