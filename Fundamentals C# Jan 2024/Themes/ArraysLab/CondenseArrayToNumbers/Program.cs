namespace CondenseArrayToNumbers
{
    internal class Program
    {
        static int[] condenseArray(int[] a)
        {
            int[] b = new int[a.Length - 1];
            for (int i =0; i < a.Length - 1; i++)
            {
                b[i] = a[i] + a[i+1];
            }

            return b;
        }

        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] condensedArray = arr;
            while(condensedArray.Length != 1)
            {
                condensedArray = condenseArray(condensedArray);
            }

            Console.WriteLine(condensedArray[0]);
            // Имаш да черпиш :)
        }
    }
}
