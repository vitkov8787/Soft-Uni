namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());//N
            int distance = int.Parse(Console.ReadLine());//M
            int exhaustion = int.Parse(Console.ReadLine());//Y
            int count = 0;
            //M-N until N<M count++
            //if N = N/2 => N/Y=0 if its Posible if not M-N 
            
            while (pokePower >= distance)
            {
                pokePower-=distance;
                count++;
                if (pokePower==Math.Floor(0.5*pokePower)) {
                    if (exhaustion != 0)
                    {
                        pokePower /= exhaustion;
                    }
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
