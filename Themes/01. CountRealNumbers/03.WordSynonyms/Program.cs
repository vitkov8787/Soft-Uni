namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //          word         sinonim
            Dictionary<string,List<string>>dictionary = new Dictionary<string,List<string>>();
            
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinomin = Console.ReadLine();
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                    dictionary[word].Add(sinomin);
                }else dictionary[word].Add(sinomin);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
