namespace _9.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numSt = int.Parse(Console.ReadLine());
            double lSaberP = double.Parse(Console.ReadLine());
            double robeP = double.Parse(Console.ReadLine());
            double beltP = double.Parse(Console.ReadLine());
            //+10% lSaber
            // everey 6th belt free

            //calc
            int numSaber = numSt +(int)Math.Ceiling(numSt * 0.1);
            Console.WriteLine(numSaber);
            double tottal =lSaberP*numSaber+robeP*numSt+beltP*numSt;
            if (numSt > 6)
            {
                double discount = (numSt / 6)*beltP;
                tottal -= discount;
            }

            if (money >= tottal)
            {
                Console.WriteLine($"The money is enough - it would cost {tottal:F2}lv.");
            }else if (money < tottal) {
                Console.WriteLine($" John will need {(tottal-money):F2}lv more.");
            }
        }
    }
}