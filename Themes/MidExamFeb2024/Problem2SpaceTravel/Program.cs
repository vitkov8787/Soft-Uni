namespace Problem2SpaceTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] route = Console.ReadLine().Split("||");
            int fuel = int.Parse(Console.ReadLine());
            int ammo = int.Parse(Console.ReadLine());

            foreach (string index in route)
            {
                string[] arg = index.Split();
                string command = arg[0];

                switch (command)
                {
                    case "Travel":
                        int distance = int.Parse(arg[1]);
                        if (fuel >= distance)
                        {
                            fuel -= distance;
                            Console.WriteLine($"The spaceship travelled {distance} light-years.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        break;

                    case "Enemy":
                        int enemyArmor = int.Parse(arg[1]);
                        if (ammo >= enemyArmor)
                        {
                            ammo -= enemyArmor;
                            Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                        }
                        else
                        {
                            int fuelConsumed = enemyArmor * 2;
                            if (fuel >= fuelConsumed)
                            {
                                fuel -= fuelConsumed;
                                Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                        }
                        break;

                    case "Repair":
                        int ammoToAdd = int.Parse(arg[1]);
                        int fuelToAdd = int.Parse(arg[1]);
                        ammo += ammoToAdd * 2;
                        fuel += fuelToAdd;
                        Console.WriteLine($"Ammunitions added: {ammoToAdd*2}.");
                        Console.WriteLine($"Fuel added: {fuelToAdd}.");
                        break;

                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        return;

                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }
    }
}

