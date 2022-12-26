using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Employee
    {
        public int empId;
        public string empName;
        private double _empSalary;
        public char empperformaceType;
        public static string companyName;
        public static string companyLocation;

       
        public void PrintEmployeeDetail()
        { Console.WriteLine("Employee Id:" + empId);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Salary:" + _empSalary);
            Console.WriteLine("Employee performace :" + empperformaceType);
            Console.WriteLine("Company Name:" + Employee.companyName);
            Console.WriteLine("Company location:" + Employee.companyLocation);
            Console.WriteLine("_________________________________________________");
        }
        public double EmpSalary
        {
            get { return _empSalary; }
            set
            {
                if (value > 3000)
                {
                    _empSalary = value;
                }
                else
                {
                    Console.WriteLine("invalid salary");
                }
            }
        }
        public void GetGrossSalaryWithBonus()
        {
            Console.WriteLine("Employee Id :" + empId);
            if (empperformaceType == 'a')
            {
                Console.WriteLine("10%");
                Console.WriteLine(_empSalary + (_empSalary * 10 / 100));
            }
            else if (empperformaceType == 'b')  
                {
                Console.WriteLine("20%");
                Console.WriteLine(_empSalary + (_empSalary * 20 / 100));
                }
                else if (empperformaceType=='c')
                {
                Console.WriteLine("30%");
                Console.WriteLine(_empSalary + (_empSalary * 30 / 100));

            }
            else
            {
                Console.WriteLine("Not Eligble for Bonus");
            }
            }
        }

    }

