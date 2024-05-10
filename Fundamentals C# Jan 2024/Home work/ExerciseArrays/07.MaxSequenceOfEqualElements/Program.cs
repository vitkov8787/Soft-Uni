namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            string charr= "";
            int times= 0;

            for (int i = arr.Length-1; i >= 0; i--)
            {
                int count = 1;
                for (int j = i-1; j >=0 ; j--)
                {   
                    if (arr[i] == arr[j]) 
                    {
                        count++;
                        if (times <= count)
                        {
                            times = count;
                            charr = arr[i];
                        }
                    }
                    else
                    {
                       
                        break;
                    }
                }
            }
            for (int i = 0; i < times; i++)
            {
                Console.Write(charr + " ");
            }
        }
    }
}
