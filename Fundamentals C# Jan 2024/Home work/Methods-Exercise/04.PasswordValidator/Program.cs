using System;

namespace _04.PasswordValidator
{
    internal class Program
    {
        //dyljina
        static bool Character(string input)
        {
            if (input.Length > 5 && input.Length < 11)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        //simvoli
        static bool LandDigs(string input)
        {
            char[] pass = new char[62]; // Use a larger array size
            bool flag = true;
            int b = 0;
            for (int i = 48; i <= 57; i++) // Numbers 0-9
            {
                pass[b] = (char)i;
                b++;
            }
            for (int i = 65; i <= 90; i++) // Uppercase letters A-Z
            {
                pass[b] = (char)i;
                b++;
            }
            for (int i = 97; i <= 122; i++) // Lowercase letters a-z
            {
                pass[b] = (char)i;
                b++;
            }
            foreach (char item in input)
            {
                if (!pass.Contains(item))
                {

                    flag = false;
                }
                else
                    flag = true;
            }

            return flag;
        }
        //dali ima nomera
        static bool Digitis(string input)
        {
            bool flag = false;
            int[] num = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            int count = 0;
            foreach (char item in input)
            {
                if (num.Contains(item))
                {
                    count++;
                    if (count > 1)
                    {
                        flag = true;

                    }
                }
            }
            return flag;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (!LandDigs(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!Character(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
           
            if (!Digitis(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


            if (Character(input) && LandDigs(input) && Digitis(input))
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
