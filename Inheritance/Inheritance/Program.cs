using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student one = new Student();
            one.StudentId = 1001;
            one.Fname = "Caitlin";
            one.Lname = "Pretorius";
            one.GetStdtDeets("Luca ", "Grey ", 321);
            Console.WriteLine("Students");
            Console.WriteLine ("{0} {1}, Student ID: {2}", one.GetStdtDeets(), one.Lname, one.StudentId);
            
            
            Teacher num1 = new Teacher();
            num1.Fname = "Willow";
            num1.Lname = "Tree";
            num1.EmployeeId = 1234;
            num1.Office = "Blue";
            Console.WriteLine("Teachers");
            Console.WriteLine("{0} {1}, {2}, {3}", num1.Fname, num1.Lname, num1.EmployeeId, num1.Office);
        }
    }
    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
    class Student : Person
    {
        public int StudentId { get; set; }

        public string GetStdtDeets(string Fname, string Lname, int StudentId)
        {
            string All = Fname + Lname + StudentId;
            return All;
        }
    }
    class Employee : Person
    {
        public int EmployeeId { get; set; }
    }
    class Teacher : Employee
    {
        public string Office { get; set; }

        public string GetTeachDeets()
        {
            return Fname;
        }

    }
}
