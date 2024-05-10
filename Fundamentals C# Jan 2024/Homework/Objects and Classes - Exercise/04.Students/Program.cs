namespace _04.Students
{
    internal class Program
    {
        class Students
        {
            public Students(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }
            public void Print()
            {
                Console.WriteLine($"{FirstName} {LastName}: {Grade:F2}");
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
        }
        static void Main(string[] args)
        {
            List<Students> stList = new List<Students>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arg = input.Split();
                string Fname = arg[0];
                string Lname = arg[1];
                double grrade = double.Parse(arg[2]);
                Students data = new Students(Fname,Lname,grrade);
                stList.Add(data);
            }

            List<Students>sorted = new List<Students>();
             sorted = stList.OrderByDescending(s=>s.Grade).ToList();
            foreach (Students item in sorted)
            {
                item.Print();
            }
        }
    }
}
/*
 * 
4
Lakia Eason 3.90
Prince Messing 5.49
Akiko Segers 4.85
Rocco Erben 6.00
 */