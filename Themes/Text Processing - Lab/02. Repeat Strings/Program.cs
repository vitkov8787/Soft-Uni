namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<string> result = new List<string>(); 
            foreach (var item in input)
            {
                for (int i = 0; i < item.Length;  i++)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
