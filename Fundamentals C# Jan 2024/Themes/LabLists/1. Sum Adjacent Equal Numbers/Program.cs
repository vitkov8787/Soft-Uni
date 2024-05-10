namespace _1._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            //for loop we stop 1 index befor the end no tot go
            // out from the border of the list.
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i +1);//remove the sec one
                    i = -1; //go back in the beginning;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
