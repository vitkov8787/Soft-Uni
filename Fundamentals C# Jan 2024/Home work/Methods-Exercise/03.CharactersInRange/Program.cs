using System;

namespace _03.CharactersInRange
{
    internal class Program
    {   
        static void CharBw( char a,char b)
        {
            if (a > b)
            {
                char temp = a;
                a = b;
                b = temp;
            }
            for (char i = (char)(a + 1); i <b; i++)
            {
                
                 Console.Write(i + " ");

            }
        }
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            CharBw(input1, input2);
        }

       
    }
}
