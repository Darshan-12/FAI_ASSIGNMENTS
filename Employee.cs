using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;

namespace week1_Assignment
{
    [Serializable]
    public class Employee
    {
        static int empno = 1000;
        public Employee()
        {
            EmployeeId = ++empno;
        }
        public Employee(int id)
        {
            EmployeeId = id;
        }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public int salary { get; set; }
        public override string ToString()
        {
            return $"{EmployeeId}, {EmployeeName}, {Address}, {salary}";
        }
    }
}
