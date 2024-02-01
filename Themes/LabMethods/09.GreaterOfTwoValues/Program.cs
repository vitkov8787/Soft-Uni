using System.Dynamic;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }

        static string GetMax(string a, string b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (type == "int")
            {
                int int1 = int.Parse(input1);
                int int2 = int.Parse(input2);
                Console.WriteLine(GetMax(int1, int2));
            }
            else if (type == "char")
            {
                char char1 = char.Parse(input1);
                char char2 = char.Parse(input2);
                Console.WriteLine(GetMax(char1, char2));
            }
            else if (type == "string")
            {
                Console.WriteLine(GetMax(input1, input2));
            }
            
        }
    }
}
