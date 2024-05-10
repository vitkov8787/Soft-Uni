using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Courses
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
            StringBuilder result = new StringBuilder();
            foreach (var item in StudentName)
            {
                result.AppendLine($"-- {item}");
            }
            return result.ToString();
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
                Console.WriteLine($"{item.Key}: {item.Value.StudentName.Count}");
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
