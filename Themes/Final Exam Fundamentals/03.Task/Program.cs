using System;

namespace _01.Task
{
    internal class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                    break;

                string[] tokens = command.Split(' ');
                string action = tokens[0];

                switch (action)
                {
                    case "Translate":
                        char charToReplace = char.Parse(tokens[1]);
                        char replacementChar = char.Parse(tokens[2]);
                        inputString = inputString.Replace(charToReplace, replacementChar);
                        Console.WriteLine(inputString);

                        break;

                    case "Includes":
                        string substring = tokens[1];
                        bool includes = inputString.Contains(substring);
                        Console.WriteLine(includes);
                        break;

                    case "Start":
                        string startSubstring = tokens[1];
                        bool startsWith = inputString.StartsWith(startSubstring);
                        Console.WriteLine(startsWith);

                        break;

                    case "Lowercase":
                        inputString = inputString.ToLower();
                        Console.WriteLine(inputString);

                        break;

                    case "FindIndex":
                        char charToFind = char.Parse(tokens[1]);
                        int lastIndex = inputString.LastIndexOf(charToFind);
                        Console.WriteLine(lastIndex);
                        break;

                    case "Remove":
                        int startIndex = int.Parse(tokens[1]);
                        int count = int.Parse(tokens[2]);
                        inputString = inputString.Remove(startIndex, count);
                        Console.WriteLine(inputString);

                        break;
                }
            }

        }
    }
}