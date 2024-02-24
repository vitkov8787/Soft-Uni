namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //list from type Song
            List<Song> list = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                string type = input[0];
                string name = input[1];
                string time = input[2];
                //call the constructor with parameters
                Song item = new Song(type, name, time);

                /*or normal when we dont have constructor with parameters
                item.Name = name;
                item.Time = time;
                item.TypeList = type;
                 */
                list.Add(item);
            }
            //filter the list with typeList
            string filter = Console.ReadLine();
           // List<Song> filterSongs = list.Where(item=>item.TypeList==filter ).ToList();

            if (filter == "all")
            {
               
                foreach (Song item in list)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach(Song item in list)
                {
                    if(item.TypeList==filter)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }

        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        //constructor with parameters
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    }
}
/*
3
favourite_DownTown_3:14
favourite_Kiss_4:16
favourite_Smooth Criminal_4:01
favourite
 */