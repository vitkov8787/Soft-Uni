namespace _04._SoftUni_Parking
{
    /*
6
register Jacob MM1111XX
register Anthony AB1111XX
unregister Jacob
register Joshua DD1111XX
unregister Lily
register Samantha AA9999B
     */
    internal class Program
    {
        class User
        {
            public User(string name, string plate)
            {
                Name = name;
                Plate = plate;
            }

            public string Name { get; set; }
            public string Plate { get; set; }

            public override string ToString()
            {
                return $"{Name} => {Plate}";
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string,User> usersList = new Dictionary<string,User>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine().Split();
                string command = arg[0];
                string name = arg[1];


                switch (command)
                {
                    case "register":
                        string plate = arg[2];
                        if (!usersList.ContainsKey(name))
                        {
                            User user = new User(name, plate);
                            usersList.Add(name, user);
                            Console.WriteLine($"{name} registered {user.Plate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {usersList[name].Plate}");
                        }
                            break;
                    case "unregister":
                        if(!usersList.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else
                        {
                            usersList.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var item in usersList)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
