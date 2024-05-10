namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>list = Console.ReadLine().Split().Select(int.Parse).ToList();
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "End"){
                    break;
                }
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) > list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        else
                        {
                            list.Insert(int.Parse(command[2]),
                                int.Parse(command[1]));
                        }
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) > list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }else list.RemoveAt(int.Parse(command[1]));
                        break;

                    case"Shift":
                            switch (command[1])
                        {
                            case "left":
                                ShLeft(list, int.Parse(command[2]));
                                break;
                            case "right":
                                ShLeft(list, int.Parse(command[2]));
                                break;
                        }
                    break;
                }  
            }
            Console.WriteLine(String.Join(" ",list));
        }
        public static void ShLeft(List<int> list ,int shifts)
        {
            for (int i = 0; i < shifts; i++)
            {
                int fElement = list[0];
                list.RemoveAt(0);
                list.Add(fElement);
            }
            
        }
        public static void ShRight<T>(List<T> list, int shifts)
        {
            for (int i = 0; i < shifts; i++)
            {// tuk mislq 4e tr dobacish -i
                T lastEl = list[list.Count - 1];
                list.RemoveAt(list.Count-1);
                list.Insert(0,lastEl);
            }
        }
    }
}
