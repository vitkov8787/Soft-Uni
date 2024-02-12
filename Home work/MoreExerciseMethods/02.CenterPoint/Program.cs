namespace _02.CenterPoint
{
    internal class Program
    {
        static void Calc(double x1, double y1, double x2, double y2)
        {
            double dist1 =(int) Math.Sqrt(x1 * x1 + y1 * y1);
            double dist2 = (int)Math.Sqrt(x2 * x2 + y2 * y2);
            if(dist1 > dist2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else Console.WriteLine($"({x1}, {y1})");

        }
        static void Main(string[] args)
        {
            // Math.Sqrt(x * x + y * y); smqtane na distanciqta 
            //4 inputa
            //proverka
            //1 metod void
            
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Calc(x1, y1, x2, y2);

        }
    }
}
