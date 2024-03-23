namespace _21115053120145_huynhkimthang_bt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>
            {
                new Department(1, "Nhan su"),
                new Department(2, "Marketing"),
                new Department(3, "IT")
            };
            List<Position> positions = new List<Position>
            {
                new Position("Ke toan vien"),
                new Position("Nhan vien tuyen dung"),
                new Position("Lap trinh vien"),
                new Position("Nhan vien marketing")
            };
            List<Employee> employees = new List<Employee> { 
                new Employee("Huynh Kim Thang", 20, positions[2], departments[2]),
                new Employee("Dinh Cong Minh", 20, positions[0], departments[0]),
                new Employee("Le Xuan Thang", 20, positions[1], departments[0]),
                new Employee("Doan Van Ca", 20, positions[3], departments[1]),
                new Employee("Hoang Van Son", 20, positions[2], departments[2])
            };
            Console.Write("Nhap tu khoa tim kiem: ");
            string keyword = Console.ReadLine().ToLower();
            Console.Write("Tuoi tu: ");
            int minAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Den tuoi: ");
            int maxAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vi tri cong viec: ");
            string positionKeyword = Console.ReadLine();
            Console.Write("Phong ban: ");
            string departmentKeyword = Console.ReadLine();
            var results = from emp in employees
                          join pos in positions on emp.Position.Name equals pos.Name
                          join dept in departments on emp.Department.IdDept equals dept.IdDept
                          where (emp.Name.ToLower().Contains(keyword) || emp.Position.Name.ToLower().Contains(keyword) || emp.Department.NameDept.ToLower().Contains(keyword))
                                  && emp.Age >= minAge && emp.Age <= maxAge
                                  && (string.IsNullOrEmpty(positionKeyword) || emp.Position.Name.ToLower() == positionKeyword.ToLower())
                                  && (string.IsNullOrEmpty(departmentKeyword) || emp.Department.NameDept.ToLower() == departmentKeyword.ToLower())
                          select emp;
            if (results != null)
            {
                Console.WriteLine("Ket qua tim kiem:");
                foreach (Employee emp in results)
                {
                    Console.WriteLine($"Ten: {emp.Name}, Tuoi: {emp.Age}, Vi tri: {emp.Position.Name}, Phong ban: {emp.Department.NameDept}");
                }
                    
            }
            else
            {
                Console.WriteLine("Khong tim thay ket qua phu hop.");
            }
        }
    }
}