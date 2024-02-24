
namespace _02.Articles
{
    class Article
    {
        public Article(string tittle, string content, string author)
        {
            Title = tittle;
            Content = content;
            Author = author;
        }
       public string Edit(string newContent)
        {
            return Content=newContent;
        }
        public string ChangeAuthor(string newAuthor)
        {
            return Author = newAuthor;
        }
        public string Rename(string newTittle)
        {
            return Title = newTittle;
        }
        public void Printing()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arguments = input.Split(", ");

            Article data = new Article(arguments[0], arguments[1], arguments[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string commands = Console.ReadLine();
                string[] arg = commands.Split(": ");
                switch (arg[0]) {
                    case "Edit":
                        data.Edit(arg[1]);
                        break;
                    case "ChangeAuthor":
                        data.ChangeAuthor(arg[1]);
                        break;
                    case "Rename":
                        data.Rename(arg[1]);
                        break;
                }
            }
            data.Printing();
        }
    }
}
/*
some title, some content, some author
3
Edit: better content
ChangeAuthor: better author
Rename: better title
 */