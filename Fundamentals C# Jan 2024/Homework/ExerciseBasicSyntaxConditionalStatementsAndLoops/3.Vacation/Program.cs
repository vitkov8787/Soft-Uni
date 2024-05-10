namespace _3.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine()); 
            string type = Console.ReadLine(); 
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                        price = 8.45;
                    if (day == "Saturday")
                        price = 9.80;
                    if (day == "Sunday")
                        price = 10.46;
                    if (numPeople > 29)
                    {
                        totalPrice = numPeople * price - numPeople * price *0.15; ;
                    }
                    else totalPrice = numPeople * price;
                    break;
                case "Business":
                    if (day == "Friday")
                        price = 10.90;
                    if (day == "Saturday")
                        price = 15.60;
                    if (day == "Sunday")
                        price = 16;
                    if (numPeople > 99)
                    {
                        totalPrice = (numPeople-10) * price;
                    }
                    else totalPrice = numPeople * price;

                    break;
                case "Regular":
                    if (day == "Friday")
                        price = 15;
                    if (day == "Saturday")
                        price = 20;
                    if (day == "Sunday")
                        price = 22.50;
                    if (numPeople >9&&numPeople<21)
                    {
                        totalPrice = numPeople * price - (numPeople * price * 0.05); 
                    }
                    else totalPrice = numPeople*price;
                    break;

            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}