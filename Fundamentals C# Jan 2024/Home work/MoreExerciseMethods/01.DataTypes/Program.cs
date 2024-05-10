using System.Diagnostics;

namespace _01.DataTypes
{
    internal class Program
    {
        
        static void Calculation(int number)
        {
            int result = number * 2;
            Console.WriteLine($"{result}");
        }
        static void Calculation(double number)
        {
            double result = number * 1.5;
            Console.WriteLine($"{result:F2}");
        }
        static void Calculation(string text)
        {
            string result = $"${text}$";
            Console.WriteLine($"{result}");
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string number = Console.ReadLine();

            switch (input)
            {
                case "int": {
                        int numberInt = int.Parse(number);
                        Calculation(numberInt);
                        break;
                    }
                case "real": {
                        double numberDouble = double.Parse(number);
                        Calculation(numberDouble);
                        break;
                    }
                case "string":
                    {
                        Calculation(number);
                        break;
                    }
            
            }
            
        }
    }
}
