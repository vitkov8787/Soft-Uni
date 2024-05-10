namespace _02.Grades
{
    internal class Program
    {
        static void Grades(double number)
        {
            switch (number)
            {
                case double n when n >= 2.00 && n < 3.00:
                    Console.WriteLine("Fail");
                    break;
                case double n when n >= 3 && n < 3.5:
                    Console.WriteLine("Poor");
                    break;
                case double n when n >= 3.5 && n < 4.5:
                    Console.WriteLine("Good");
                    break;
                case double n when n >= 4.5 && n < 5.5:
                    Console.WriteLine("Very good");
                    break;
                case double n when n >= 5.5 && n <= 6:
                    Console.WriteLine("Excellent");
                    break;
            }
        }

        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Grades(number);
        }
    }
}
