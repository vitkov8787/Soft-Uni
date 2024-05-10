namespace Problem3DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arg = input.Split(", ");

                switch (arg[0])
                {
                    case "Add":
                        if (!list.Contains(arg[1]))
                        {
                            list.Add(arg[1]);
                            Console.WriteLine("Card successfully added");
                        }
                        else
                        {
                            Console.WriteLine("Card is already in the deck");
                        }
                        break;

                    case "Remove":
                        if (list.Contains(arg[1]))
                        {
                            list.Remove(arg[1]);
                            Console.WriteLine("Card successfully removed");
                        }
                        else
                        {
                            Console.WriteLine("Card not found");
                        }
                        break;

                    case "Remove At":
                        int index = int.Parse(arg[1]);
                        if (index >= 0 && index < list.Count)
                        {
                            list.RemoveAt(index);
                            Console.WriteLine("Card successfully removed");
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;

                    case "Insert":
                        int insertIndex = int.Parse(arg[1]);
                        if (insertIndex >= 0 && insertIndex < list.Count)
                        {
                            if (!list.Contains(arg[2]))
                            {
                                list.Insert(insertIndex, arg[2]);
                                Console.WriteLine("Card successfully added");
                            }
                            else
                            {
                                Console.WriteLine("Card is already added");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Index out of range");
                        }
                        break;
                    }   
                }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}


