namespace _01.Task
{
    /*
Enroll Stefan
Enroll Peter
Enroll Stefan
Learn Stefan ItShouldWork
Learn John ItShouldNotWork
Unlearn George Dispel

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                    break;

                string[] commandParts = input.Split(' ');
                string heroName = commandParts[1];

                switch (commandParts[0])
                {
                    case "Enroll":
                        if (!heroes.ContainsKey(heroName))
                            heroes.Add(heroName, new List<string>());
                        else
                            Console.WriteLine($"{heroName} is already enrolled.");
                        break;

                    case "Learn":
                        string spellName = commandParts[2];
                        if (heroes.ContainsKey(heroName))
                        {
                            if (!heroes[heroName].Contains(spellName))
                                heroes[heroName].Add(spellName);
                            else
                                Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                        else
                            Console.WriteLine($"{heroName} doesn't exist.");
                        break;

                    case "Unlearn":
                        spellName = commandParts[2];
                        if (heroes.ContainsKey(heroName))
                        {
                            if (heroes[heroName].Contains(spellName))
                                heroes[heroName].Remove(spellName);
                            else
                                Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                        else
                            Console.WriteLine($"{heroName} doesn't exist.");
                        break;
                }
            }

            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
