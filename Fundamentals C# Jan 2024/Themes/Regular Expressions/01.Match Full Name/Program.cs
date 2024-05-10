using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string input = Console.ReadLine();
            RegexOptions options = RegexOptions.Singleline;

            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                Console.Write("{0} ", m.Value, m.Index,options);
            }
        }
    }
}
