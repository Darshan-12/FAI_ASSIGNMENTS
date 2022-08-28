using System; 
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 
using System.Xml.Serialization;
namespace week1_Assignment
{
    class Assignment15
    {




        static Employee createEmployee()
        {
            var id = Util.GetNumber("Enter the ID of the Employee");
            var name = Util.GetString("Enter the Name of the Employee");
            var address = Util.GetString("Enter the Address of the Employee");
            var salary = Util.GetNumber("Enter the Salary");
            var emp = new Employee(id)
            {
                EmployeeName = name,
                Address = address,
                salary = salary
            };

            return emp;
        }

        static void saveAsXml(List<Employee> empList)
        {
            var fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.Write);
            var formatter = new XmlSerializer(typeof(List<Employee>));
            formatter.Serialize(fs, empList);
            fs.Close();
        }

        static List<Employee> loadXmlData()
        {
            var fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            var formatter = new XmlSerializer(typeof(List<Employee>));
            var list = formatter.Deserialize(fs) as List<Employee>;
            fs.Close();
            return list;
        }

        static void Main(string[] args)
        {
            int size = Util.GetNumber("Enter the number of employeeto be added");
            List<Employee> empList = new List<Employee>();
            for(int i=0;i<size;i++)
            {
                empList.Add(createEmployee());
            }
            //empList.Add(new Employee { EmployeeName = "virat", Address = "Shivaogga", salary = 50000 });
            //empList.Add(new Employee { EmployeeName = "rohit", Address = "Bhadravathi", salary = 40000 });
            //empList.Add(new Employee { EmployeeName = "darshan", Address = "Hubli", salary = 200000 });
            //empList.Add(new Employee { EmployeeName = "Sudeep", Address = "Hyderabad", salary = 600000 });
            //empList.Add(new Employee { EmployeeName = "Sandeep", Address = "Tanil nadu", salary = 600000 });
            saveAsXml(empList);

            empList = loadXmlData();
            foreach (var emp in empList) Console.WriteLine($"Employee id:{emp.EmployeeId}\tEmployee name:{emp.EmployeeName}\tEmployee address:{emp.Address}\tEmployee salary:{emp.salary}");
        }
    }
}