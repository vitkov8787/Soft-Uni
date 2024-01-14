namespace _1.Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* · 0-2 – baby

               · 3-13 – child

                · 14-19 – teenager

                · 20-65 – adult

                · >= 66 – elder*/
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case int age when input == 0 && input <= 2:
                    Console.WriteLine("baby");
                    break;
                    case int age when input >2 && input<14:
                    Console.WriteLine("child");
                    break;
                case int age when input > 13 && input < 20:
                    Console.WriteLine("teenager");
                    break;
                case int age when input > 19 && input < 66:
                    Console.WriteLine("adult");
                    break;
                case int age when input > 65:
                    Console.WriteLine("elder");
                    break;
            }
        }
    }
}