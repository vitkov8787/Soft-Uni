using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            while (true)
            {
                string metals = Console.ReadLine();
                if (metals == "stop")
                    break;
                int amount = int.Parse(Console.ReadLine());


                if (!dictionary.ContainsKey(metals))
                {
                    dictionary.Add(metals, amount);
                } else dictionary[metals] += amount;

                           
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
