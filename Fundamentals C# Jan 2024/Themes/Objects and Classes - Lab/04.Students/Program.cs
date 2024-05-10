using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] arg = input.Split();
                Student item = new Student(arg[0], arg[1], arg[2], arg[3]);
                listOfStudents.Add(item);
                input = Console.ReadLine();
            }

            string filtter = Console.ReadLine();
            List<Student>filtterList = listOfStudents.Where(item=>item.HomeTown==filtter).ToList();
            foreach (Student item in filtterList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
        public Student(string firstName, string lastName, string age, string homeTown)
        {

            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }


    }
}
/*
Anthony Taylor 15 Chicago
David Anderson 16 Washington
Jack Lewis 14 Chicago
David Lee 14 Chicago
end
Chicago
 */