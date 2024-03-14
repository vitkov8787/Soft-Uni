using System.Text;
using System.Xml.Linq;

namespace _0._5._1
{
    class Course
    {
        public Course(string courseName)
        {
            CourseName = courseName;
            StudentName = new List<string>();
        }

        public string CourseName { get; set; }
        public List<string> StudentName { get; set; }

        public override string ToString()
        {
            return $"{CourseName}: {StudentName.Count}\n-- {string.Join("\n-- ", StudentName)}";
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> dictionary = new Dictionary<string, Course>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arg = input.Split(" : ");
                string courseName = arg[0];
                string studentName = arg[1];

                if (!dictionary.ContainsKey(courseName))
                {
                    dictionary.Add(courseName, new Course(courseName));
                }

                dictionary[courseName].StudentName.Add(studentName);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
/*
Algorithms : Jay Moore
Programming Basics : Martin Taylor
Python Fundamentals : John Anderson
Python Fundamentals : Andrew Robinson
Algorithms : Bob Jackson
Python Fundamentals : Clark Lewis
end
 */