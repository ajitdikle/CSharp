
using EmployeeProject;

namespace Maveric.Runner
{
    public class Program
    {
        static void Main(string[] args)
        { //
            Console.WriteLine("employee Dashboard");
            Employee.companyName = "Maveric";
            Employee.companyLocation = "pune";
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            emp1.empId = 101;
            emp1.empName = "saul";
            //emp1.empSalary = 9000;
            emp1.empperformaceType = 'a';
            emp1.EmpSalary = 9000;

            emp2.empId = 102;
            emp2.empName = "kim";
            //emp2.empSalary = 1200.2;
            emp2.empperformaceType = 'b';
            emp2.EmpSalary = 1200.2;

            emp3.empId = 103;
            emp3.empName = "jack";
            //emp3.empSalary = 6000.2;
            emp3.empperformaceType = 'c';
            emp3.EmpSalary = -6000.2;

            Console.WriteLine(emp1.empId);
            Console.WriteLine(emp1.empName);
            Console.WriteLine(emp1.EmpSalary);
            Console.WriteLine(emp2.empId);
            Console.WriteLine(emp2.empName);
            Console.WriteLine(emp2.EmpSalary);

            emp2.PrintEmployeeDetail();
            emp1.PrintEmployeeDetail();
            emp3.PrintEmployeeDetail();

            emp1.GetGrossSalaryWithBonus();
            emp2.GetGrossSalaryWithBonus();
            emp3.GetGrossSalaryWithBonus();
        }
    }
}
