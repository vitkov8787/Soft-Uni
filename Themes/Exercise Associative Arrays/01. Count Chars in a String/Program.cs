namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputTex = Console.ReadLine().Split();
            

            Dictionary<char,int> dictionary = new Dictionary<char,int>();
            foreach (var item in inputTex)
            {
                foreach (var charr in item)
                {
                    if (!dictionary.ContainsKey(charr))
                    {
                        dictionary.Add(charr, 1);
                    }else dictionary[charr]++;
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
