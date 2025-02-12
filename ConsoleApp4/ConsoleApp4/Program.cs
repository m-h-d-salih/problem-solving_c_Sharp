namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee {Id=1,Name="salih",Salary=5000,Department="it"},
                  new Employee {Id=2,Name="goopz",Salary=2000,Department="sales"},
                    new Employee {Id=3,Name="fasal",Salary=3000,Department="it"},
                      new Employee {Id=4,Name="priya",Salary=4000,Department="finance"},
            };
            //var highsal=from emp in list  //query syntax
            //            where emp.Salary>3000
            //            select emp;
            var highsal = list.Where(e => e.Salary > 3000); //lambda expression
            foreach (var emp in highsal )
            {
                Console.WriteLine(emp.Name+" = "+emp.Salary );
            }
            //var ordering=from emp in list
            //             orderby emp.Salary
            //             select emp;
            var ordering = list.OrderBy(e => e.Salary);
            foreach (var emp in ordering)
            {
                Console.WriteLine(emp.Name + " = " + emp.Salary);
            }
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
    }
}
