﻿namespace _05.AddAndSubtract
{
    internal class Program
    {
        static int Sum(int num1, int num2)
        {
           return num1 + num2;
        }
        static int Subb(int num1, int num2,int num3)
        {
            return Sum(num1,num2)- num3;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Subb(num1,num2,num3));
        }
    }
}
