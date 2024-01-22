namespace _08.BeerKegs
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double bigestVolume=double.MinValue;
            string result="";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume= Math.PI*radius *radius* height;
                if (bigestVolume < volume)
                {
                    bigestVolume = volume;
                    result = model;
                }
            }
            Console.WriteLine(result);
        }
    }
}
