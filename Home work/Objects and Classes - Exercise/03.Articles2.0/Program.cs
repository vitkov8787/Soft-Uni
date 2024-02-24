namespace _03.Articles2._0
{
    internal class Program
    {
        class Article
        {
            public Article(string tittle, string content, string author)
            {
                Title = tittle;
                Content = content;
                Author = author;
            }
            public void Printing()
            {
                Console.WriteLine($"{Title} - {Content}: {Author}");
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
        }
        static void Main(string[] args)
        {
            List<Article> list = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string commands = Console.ReadLine();
                string[] arg = commands.Split(", ");
                Article data = new Article(arg[0], arg[1], arg[2]);
                list.Add(data);
                //data.Printing();
            }
            foreach (Article item in list)
            {
                item.Printing();
            }
        }
    }
}
