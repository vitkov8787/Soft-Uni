using System.Globalization;

namespace _07._Company_Users
{
    internal class Program
    {
        class InfoCompany
        {
            public InfoCompany(string companyName)
            {
                CompanyName = companyName;
                EmployeID = new List<string>();
            }

            public  string CompanyName { get; set; }
            public List<string> EmployeID { get; set; }

            public void AddEmployee(string employeeId)
            {
                if (!EmployeID.Contains(employeeId))
                    
                EmployeID.Add(employeeId);
            }
            public override string ToString()
            {
                return $"{CompanyName}\n-- {string.Join("\n-- ", EmployeID)}";

            }

        }
        static void Main(string[] args)
        {
            Dictionary<string,InfoCompany> dictionary =new Dictionary<string,InfoCompany>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split(" -> ");
                string companyName = arg[0];
                string employeID = arg[1];
                if (!dictionary.ContainsKey(companyName))
                {
                    dictionary.Add(companyName,new InfoCompany(companyName));
                }
                dictionary[companyName].AddEmployee(arg[1]);

            }

            foreach (var item in dictionary)
            {
                Console.WriteLine((item.Value));
            }
        }
    }
}
/*
SoftUni -> AA12345
SoftUni -> CC12344
Lenovo -> XX23456
SoftUni -> AA12345
Movement -> DD11111
End
 */