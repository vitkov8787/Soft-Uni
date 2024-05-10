namespace _01._CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] intputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

            foreach (double index in intputNumbers)
            {
                if (dictionary.ContainsKey(index))
                {
                    dictionary[index]++;
                }
                else
                {
                    dictionary.Add(index, 1);
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
