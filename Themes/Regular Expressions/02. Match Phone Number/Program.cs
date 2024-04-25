using System.Text.RegularExpressions;
namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}";
            string input = Console.ReadLine();
            
            var match = Regex.Matches(input, pattern);
            var matchPone = match.Cast<Match>().Cast<Match>().Select(a=>a.Value.Trim
            ()).ToArray();
            Console.WriteLine(string.Join(", ",matchPone));
            var test=Regex.Matches(input, pattern).ToList();
            foreach (var item in test)
            {
                Console.Write($"{item},");
            }
        }
    }
}
