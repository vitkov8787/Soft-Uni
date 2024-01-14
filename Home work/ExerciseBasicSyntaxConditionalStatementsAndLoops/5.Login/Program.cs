namespace _5.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string user = Console.ReadLine();
            string revPass = "";
            int flag = 1;

            for (int i = user.Length - 1; i >= 0; i--)
            {
                revPass += user[i];
            }

            while (flag<=4)
            {
                string inputPassword = Console.ReadLine();
                if (inputPassword == revPass)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else 
                {
                    if (flag == 4)
                    {
                        Console.WriteLine($"User {user} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    flag += 1;          
                }
            }       
        }   
    }
}