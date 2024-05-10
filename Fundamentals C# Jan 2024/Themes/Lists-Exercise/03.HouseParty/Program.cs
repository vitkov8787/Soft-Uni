using System.ComponentModel;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arg = input.Split();
                //проверява дали поне един елемент в списъка list отговаря
                //на условието item == arg[0].
                bool has = list.Any(item => item == arg[0]);
                if (arg[2] == "going!")
                {
                    if (!has)
                    {
                        list.Add(arg[0]);
                    }
                    else Console.WriteLine($"{arg[0]} is already in the list!");
                }
                else if (arg[2] == "not")
                {
                    if (has)
                    {
                        list.Remove(arg[0]);
                    }
                    if (!has)
                    {
                        Console.WriteLine($"{arg[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(String.Join("\n", list));   
        }
    }
}

/*
4
Allie is going!
George is going!
John is not going!
George is not going!
*/