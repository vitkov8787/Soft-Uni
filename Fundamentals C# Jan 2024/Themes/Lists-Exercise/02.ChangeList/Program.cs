namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();
                if (input == "end")
                {
                    break;
                }
                switch (command[0])
                {
                    case "Delete":
                        list.RemoveAll(item => item == int.Parse(command[1]));
                        break;
                    case "Insert":
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
