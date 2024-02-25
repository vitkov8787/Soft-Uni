namespace _07.OrderbyAge
{
    internal class Program
    {
        class People
        {
            public People(string name, string id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }

            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }

        }
        static void Main(string[] args)
        {
            List<People> list = new List<People>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split();
                People data = new People(arg[0], arg[1], int.Parse(arg[2]));
                People found = list.FirstOrDefault(x => x.Id == data.Id);
                if (found != null)
                {
                    found.Age = data.Age;
                    found.Name = data.Name;
                }
                else list.Add(data);
            }
            List<People>orderList = list.OrderBy(x => x.Age).ToList();
            foreach (People item in orderList)
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }
}
