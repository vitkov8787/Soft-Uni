namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static int FsMalest(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];

            for (int i = 0; i < 3; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());  
            }
            int result = FsMalest(arr1[0], arr1[1], arr1[2]);
            Console.WriteLine(result);
        }
    }
}
