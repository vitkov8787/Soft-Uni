namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Array.Empty<int>();
           
            for (int i = 0;i<arr.Length;i++)
            {
                bool flag = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        flag = false;
                        break;
                    }
                }
                    if(flag)   {
                      
                        Array.Resize(ref arr2, arr2.Length + 1);
                        arr2[arr2.Length - 1] = arr[i];
                    }
                }
                
            
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
