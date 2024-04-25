using System.Globalization;
using System.Text.RegularExpressions;

namespace _03.Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            var input = Console.ReadLine();
            var output = Regex.Matches(input, patern);

            foreach (Match item in output)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}