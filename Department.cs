using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21115053120145_huynhkimthang_bt
{
    internal class Department
    {
        private int idDept;
        private string nameDept;
        private List<Employee> employees;
        public Department() { }

        public Department(int idDept, string nameDept)
        {
            this.IdDept = idDept;
            this.NameDept = nameDept;
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public int IdDept { get => idDept; set => idDept = value; }
        public string NameDept { get => nameDept; set => nameDept = value; }
    }
}
