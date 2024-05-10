namespace _06._Student_Academy
{
    /*
5
John
5.5
John
4.5
Alice
6
Alice
3
George
5
     */
    internal class Program
    {
        class Student
        {
            public Student(string name, double grade, int count)
            {
                Name = name;
                Grade = grade;
                this.count = count;
            }

            public string Name { get; set; }
            public double Grade { get; set; }
            public int count { get; set; }
            public double AvGrade => Grade / count;
        }
        static void Main(string[] args)
        {
            double avGrade = 4.50;
            Dictionary<string, Student> dictionary = new Dictionary<string, Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                //  Student data = new Student(name, grade, i);
                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new Student(name, grade, 1));
                }
                else
                {
                    dictionary[name].Grade += grade;
                    dictionary[name].count++;
                }

            }

            foreach (var item in dictionary)
            {
                if (item.Value.AvGrade >= avGrade)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.AvGrade:F2}");
                }
            }
        }
    }
}
