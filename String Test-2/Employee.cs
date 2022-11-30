using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrString_Test
{
    class Employee
    {
        int id;
        String name;
        Dept d;

        public Employee()
        {

        }

        public Employee(int id, string name, Dept d)
        {
            this.id = id;
            this.name = name;
            this.d = d;
        }

        public override string ToString()
        {
            return "ID : " + id + "\tName : " + name + "\tDepartment name : " + d.deptName + "\tDepatId : "+ d.deptId ;
        }
    }
    class Dept
    {
        public String deptName;
        public int deptId;

        public Dept()
        {

        }

        public Dept(string deptName, int deptId)
        {
            this.deptName = deptName;
            this.deptId = deptId;
        }
    }

    class Mainclass
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            
            emp[0] = new Employee(1, "Abhi",new Dept("Development", 100));
            emp[1] = new Employee(2, "Ranveer", new Dept("Entertainment", 101));
            emp[2] = new Employee(3, "Tharun", new Dept("Design", 102));

            for(int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i]);
            }
        }
    }
}
