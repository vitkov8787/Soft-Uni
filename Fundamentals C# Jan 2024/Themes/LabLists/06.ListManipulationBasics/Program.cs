namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end") break;
                string[] comands = line.Split();
                switch (comands[0])
                {
                    case "Add":
                        list.Add(int.Parse(comands[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(comands[1]));
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(comands[1]));
                        break;
                    case "Insert":
                        list.Insert(int.Parse(comands[2]), int.Parse(comands[1]));
                        break;
                }

            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
