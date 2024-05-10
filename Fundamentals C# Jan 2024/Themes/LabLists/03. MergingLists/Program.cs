namespace _03._MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> list2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            int minLength = Math.Min(list1.Count, list2.Count);

            for (int i = 0; i < minLength; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[i]);
            }

            result.AddRange(list1.Skip(minLength));
            result.AddRange(list2.Skip(minLength));



            Console.WriteLine(string.Join(" ",result));
        }
    }
}
