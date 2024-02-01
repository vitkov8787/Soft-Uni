using System;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = -1;
            int sum = 0;

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] == arr1[i])
                {
                    sum += arr[i];
                }
                else
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
