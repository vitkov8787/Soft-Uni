using System.Text.RegularExpressions;

namespace _02Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                // Check if the input message is valid
                bool isValid = IsValidMessage(input);

                if (isValid)
                {
                    // Decrypt the message
                    string decryptedMessage = DecryptMessage(input);
                    Console.WriteLine(decryptedMessage);
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }

        static bool IsValidMessage(string input)
        {
            // Regular expression pattern for valid messages
            string pattern = @"^([$%])([A-Z][a-z]{2,})\1:\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";
            return Regex.IsMatch(input, pattern);
        }

        static string DecryptMessage(string input)
        {
            // Extract tag and numbers from the input
            Match match = Regex.Match(input, @"^([$%])([A-Z][a-z]{2,})\1:\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$");
            string tag = match.Groups[2].Value;
            int num1 = int.Parse(match.Groups[3].Value);
            int num2 = int.Parse(match.Groups[4].Value);
            int num3 = int.Parse(match.Groups[5].Value);

            char char1 = (char)num1;
            char char2 = (char)num2;
            char char3 = (char)num3;

            return $"{tag}: {char1}{char2}{char3}";
        }
    }
}
