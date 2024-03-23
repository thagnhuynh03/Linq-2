using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21115053120145_huynhkimthang_bt
{
    internal class Employee
    {
        private string name;
        private int age;
        private Position position;
        private Department department;
        
        public Employee() { }
        
        public Employee(string name, int age, Position position, Department department)
        {
            this.Name = name;
            this.Age = age;
            this.Position = position;
            this.Department = department;
            department.AddEmployee(this);
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        internal Position Position { get => position; set => position = value; }
        internal Department Department { get => department; set => department = value; }
    }
}
