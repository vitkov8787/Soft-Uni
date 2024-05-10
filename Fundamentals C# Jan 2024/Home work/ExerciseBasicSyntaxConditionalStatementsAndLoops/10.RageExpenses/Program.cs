namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount =int.Parse(Console.ReadLine());
            float headSetP = float.Parse(Console.ReadLine());
            float mouseP = float.Parse(Console.ReadLine());
            float keyP = float.Parse(Console.ReadLine());
            float displayP = float.Parse(Console.ReadLine());
            float sum = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    sum += headSetP;
                    
                } if (i % 3 == 0) {
                sum+= mouseP;
                 
                } if((i % 6)== 0) {
                sum += keyP;
                    
                }
                if ((i % 12) == 0)
                {
                    sum += displayP;
                }
            }
            Console.WriteLine($"Rage expenses: {sum:F2} lv.");
        }
    }
}