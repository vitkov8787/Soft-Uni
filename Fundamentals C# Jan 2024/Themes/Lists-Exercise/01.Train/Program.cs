namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int max = int.Parse(Console.ReadLine());

            

            while(true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                string[]comand = input.Split();
                if (comand[0] == "Add")
                {
                    list.Add(int.Parse(comand[1]));
                }
                else
                {
                    int numPass = int.Parse(input);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + numPass <= max)
                        {
                            list[i] += numPass;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ",list));
        }
    }
}