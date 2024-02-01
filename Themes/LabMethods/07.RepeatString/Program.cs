namespace _07.RepeatString
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepStr(text, n)); 
        }

        private static string RepStr(string text,int n)
        {
            string result= "";

            for (int i = 0; i < n; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
