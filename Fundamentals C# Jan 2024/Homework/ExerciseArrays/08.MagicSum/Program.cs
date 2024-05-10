namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which prints all unique pairs
            //in an array of integers whose sum is equal to a
            //given number.
           
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a, b;
            int input = int.Parse(Console.ReadLine());
            // if there i == ->  i = a j = b;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == input)
                    {
                        a = arr[i]; b = arr[j];
                        Console.WriteLine($"{a} {b}");
                    }
                }
            }
        }
    }
}
