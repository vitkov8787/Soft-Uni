namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //   Length
            int[] arr0 = new int[n];
            int[] arr1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                //we rewrite the index[0] and [1] of dum array every iteration of for loop //<---
                int[]dum = Console.ReadLine().Split().Select(int.Parse).ToArray();//<---

                //here we chek if i is even or no and if it's not we flip the index's in
                //the original arrays 
                if (i % 2 == 0)//<---
                {
                    arr0[i] = dum[0];
                    arr1[i] = dum[1];
                }
                else
                {
                    arr0[i] = dum[1];
                    arr1[i] = dum[0];
                }
            }
            Console.WriteLine(String.Join(" ",arr0));
            Console.WriteLine(String.Join(" ", arr1));
        }
    }
}

