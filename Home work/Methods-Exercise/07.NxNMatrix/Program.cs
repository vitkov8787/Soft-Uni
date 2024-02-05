namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Matrix(int num)
        {

            for (int i = 0; i < num; i++)
            {
                for (global::System.Int32 j = 0; j < num; j++)
                {
                    Console.Write(num.ToString()+" ");
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //dva vlojeni forlupa
            Matrix(num);
        }
    }
}
