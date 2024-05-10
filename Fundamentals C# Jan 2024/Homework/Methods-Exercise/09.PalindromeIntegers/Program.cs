namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static bool Checking(string input)
        {// string to char arr
            char[] arrInput = input.ToCharArray();
            Array.Reverse(arrInput);//revers the new arr
            string reverse = new string(arrInput);//save the new arr in var
            //check
            return input == reverse;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") 
                {
                    break;
                }
                Console.WriteLine(Checking(input));
            }
        }
    }
}
