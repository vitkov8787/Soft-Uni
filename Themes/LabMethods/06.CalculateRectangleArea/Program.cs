namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static double Area(double a, double b)
        {
            return a * b;    
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Area(a,b));      
        }
    }
}
