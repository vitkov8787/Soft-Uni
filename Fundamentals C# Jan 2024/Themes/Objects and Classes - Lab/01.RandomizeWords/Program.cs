namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split();

            Random rand = new Random();
            for (int i = words.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }
            //Welcome to SoftUni and have fun learning programming


            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
