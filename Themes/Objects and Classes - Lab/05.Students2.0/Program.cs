namespace _05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list for objects
            List<Student> listOfStudents = new List<Student>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] arg = input.Split();

                //empty student object
                Student obj = null;

                foreach (Student ojectItem in listOfStudents)
                {
                    if (ojectItem.FirstName == arg[0] && ojectItem.LastName == arg[1])
                    {
                        //празния обект присвоява съществувашия
                        obj=ojectItem;
                    }
                }
                if (obj == null)
                {
                    listOfStudents.Add(new Student(arg[0], arg[1], arg[2], arg[3]));
                    input = Console.ReadLine();
                }
                else
                {
                    //понеже празният обект вече не е празен(той вече е взел съществуващият
                    //му сменяме само нужните данни
                    obj.Age = arg[2];
                    obj.HomeTown= arg[3];
                    input = Console.ReadLine();
                }

            }

            /*
John Smith 15 Sofia
Peter Johnson 14 Plovdiv
Peter Johnson 25 Plovdiv
Linda Bridge 16 Sofia
Linda Bridge 27 Sofia
Simon Stone 12 Varna
end
Sofia

Anthony Taylor 15 Chicago
David Anderson 16 Washington
Jack Lewis 14 Chicago
David Lee 14 Chicago
Jack Lewis 26 Chicago
David Lee 18 Chicago
end
Chicago
             */


            string filtter = Console.ReadLine();
            List<Student> filtterList = listOfStudents.Where(item => item.HomeTown == filtter).ToList();
            foreach (Student item in filtterList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
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
}
