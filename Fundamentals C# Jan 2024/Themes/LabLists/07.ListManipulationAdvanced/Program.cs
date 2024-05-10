using System.Numerics;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool flag = false;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end") {
                    if (flag)
                    {
                        Console.WriteLine(string.Join(" ", list));
                    }
                    break;
                } 
                string[] comands = line.Split();
                switch (comands[0])
                {
                    case "Add":
                        list.Add(int.Parse(comands[1]));
                        flag = true;
                        break;
                    case "Remove":
                        list.Remove(int.Parse(comands[1]));
                        flag = true;
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(comands[1]));
                        flag = true;
                        break;
                    case "Insert":
                        list.Insert(int.Parse(comands[2]), int.Parse(comands[1]));
                        flag = true;
                        break;
                    case "Contains":
                        if (list.Contains(int.Parse(comands[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else Console.WriteLine("No such number");
                        break;
                    case "PrintEven":
                        List<int> even = list.Where(item => item % 2 == 0).ToList();
                        Console.WriteLine(string.Join(" ", even));
                        break;
                    case "PrintOdd":
                        List<int> odd = list.Where(item => item % 2 != 0).ToList();
                        Console.WriteLine(string.Join(" ", odd));
                        break;
                    case "GetSum":
                        BigInteger sum = 0;
                        foreach (var item in list)
                        {

                            sum += item;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        List<int>result = new List<int>();
                        switch (comands[1])
                        {
                            case ">":
                                foreach (var item in list)
                                {
                                    if (item > int.Parse(comands[2]))
                                    {
                                        result.Add(item);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", result));
                                break;
                                case "<":
                                foreach (var item in list)
                                {
                                    if (item < int.Parse(comands[2]))
                                    {
                                        result.Add(item);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", result));
                                break;
                            case ">=":
                                foreach (var item in list)
                                {
                                    if (item >= int.Parse(comands[2]))
                                    {
                                        result.Add(item);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", result));
                                break;
                            case "<=":
                                foreach (var item in list)
                                {
                                    if (item <= int.Parse(comands[2]))
                                    {
                                        result.Add(item);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", result));
                                break;
                        }
                        break;
                }
            }
        }
    }
}
