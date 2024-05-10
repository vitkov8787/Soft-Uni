namespace _08.MathPower
{
    internal class Program
    {
        static double Pow(double basee, int power)
        {
            // return (double)Math.Pow(basee, power);
            //or 
            double answer = 1;
            for (int i = 0; i < power; i++)
            {
                answer *= basee;
            }
            return answer;
        }
        static void Main(string[] args)
        {
            double basee = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(Pow(basee, power));
        }
    }
}
