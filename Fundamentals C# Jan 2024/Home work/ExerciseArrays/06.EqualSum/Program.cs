namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
           
            int sum = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int left=0;
                int right=0;

                for (int j = 0; j < i; j++)
                {
                    left += arr[j];
                }
                for(int j = i+1;j < arr.Length; j++)
                {
                    right += arr[j];
                }
                if(right == left)
                {
                    
                    sum = i;
                    break;
                }

            }
            if (sum==-1)
            {
                Console.WriteLine("no");
            }else { Console.WriteLine(sum); }
        }
    }
}
