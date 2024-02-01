using System;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');
            //foreach (string element in arr2)
            //{
            //    if (Array.IndexOf(arr1, element) != -1)
            //    {
            //retunr -1 if there is no common elements
            //        Console.Write($"{element} ");
            //    }
            //}
            
            for (int i = 0; i < arr2.Length; i++)
            {
                foreach (var item in arr1)
                {
                    if(item == arr2[i])
                    {
                        Console.Write(item+" ");
                    }
                }
            }
        }
    }
}
