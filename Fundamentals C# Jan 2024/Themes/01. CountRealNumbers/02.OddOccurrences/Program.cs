namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split();
            //          key    value
            Dictionary<string,int> dictionary = new Dictionary<string,int>();
              foreach (string item in inputWords)
            {
                string wordsLowCase = item.ToLower();

                if (dictionary.ContainsKey(wordsLowCase))
                {
                    dictionary[wordsLowCase]++;
                }
                else dictionary.Add(wordsLowCase, 1);
            }
            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
