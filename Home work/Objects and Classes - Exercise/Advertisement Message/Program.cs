namespace Advertisement_Message
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            List<Text> list = new List<Text>(); 

            List<string> Phrases = new List<string>{"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
            "Exceptional product.", "I can't live without this product."};
            List<string> Events = new List<string>{"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            List<string> Authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> Cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string phrases = Phrases[rnd.Next(Phrases.Count)];
                string events = Events[rnd.Next(Events.Count)];
                string authors = Authors[rnd.Next(Authors.Count)];
                string cities = Cities[rnd.Next(Cities.Count)];
                Text data = new Text(phrases,events,authors,cities);

                data.Pr(phrases,events,authors,cities);
            }
            
        }
        class Text
        {
            public Text(string phrases, string events, string authors, string cities)
            {
                Phrases = phrases;
                Events = events;
                Authors = authors;
                Cities = cities;
               
            }
            public void Pr(string phrases,string events,string authors,string cities)
            {
                Console.WriteLine($"{phrases} {events} {authors} – {cities}.");
            }
            public string Phrases { get; set; }
            public string Events  { get; set; }
            public string Authors { get; set; }
            public string Cities { get; set; }

           
        }
    }
}
