using FirmEmployee.Employees;
using System;
using System.Collections.Generic;

namespace FirmEmployee
{
    public class Firm
    {
        private List<Employee> employees;

        public List<Employee> Employees
        {
            set
            {
                employees = value;
            }
            get { return employees; }
        }

        public Firm()
        {
            this.employees = new List<Employee>();
        }

        //public void DoEmployee()
        //{
        //    Employee em = new Employee { Name = "Name1", Surname = "Surname1", Experience = "Ex1" };
        //    employees += em;
        //    employees = employees + new Employee { Name = "Name2", Surname = "Surname2", Experience = "Ex2" };
        //    employees += new Employee { Name = "Name2", Surname = "Surname2", Experience = "Ex2" };
        //    employees += new Manager { Name = "Manager1", Surname = "SurManeger1", Experience = "Ex1" };
        //    employees += new Foreman { Name = "Foreman1", Surname = "SurForeman1", Experience = "Ex1" };

        //    foreach (Employee employee in employees)
        //    {
        //        Console.WriteLine($" {employee.Name} {employee.Surname} with exp {employee.Experience}");
        //    }
        //    Console.WriteLine($"Amount of employees: {employees.EmployeeCount()}");

        //    employees -= new Employee { Name = "Name1", Surname = "Surname1", Experience = "Ex1" };
        //    employees -= new Employee { Name = "Name1", Surname = "Surname1", Experience = "Ex1" };
        //    employees -= new Foreman { Name = "Foreman1", Surname = "SurForeman1", Experience = "Ex1" };//Employee / Manager / Worker - без разницы

        //    foreach (Employee employee in employees)
        //    {
        //        Console.WriteLine($" {employee.Name} {employee.Surname} with exp {employee.Experience}");
        //    }
        //    Console.WriteLine($"Amount of employees: {employees.EmployeeCount()}");

        //    Console.WriteLine(employees.IsEmployeeInFirm(new Employee { Name = "Name2", Surname = "Surname2", Experience = "Ex2" }));
        //    Console.WriteLine(employees.IsEmployeeInFirm(new Foreman { Name = "Foreman1", Surname = "SurForeman1", Experience = "Ex1" }));

        //    employees.EmployeeList();

        //    employees += new Employee { Name = "Name1", Surname = "Bublii", Experience = "Exrwtgre2" };

        //}

        public static Firm operator +(Firm firm, Employee employee)
        {
            if (IsExist(firm.Employees, employee))
            //if(firm.Employees.Contains(employee))
            {
                Console.WriteLine($"Can't add. Such employee: - {employee.Name} {employee.Surname} with experince {employee.Experience}, already in firm.");
                return firm;
            }
            firm.Employees.Add(employee);
            Console.WriteLine($"Employee added to firm successfully.");
            return firm;
        }

        public static Firm operator -(Firm firm, Employee employee)
        {
            if (!IsExist(firm.Employees, employee))
            //if (!firm.Employees.Contains(employee))
            {
                Console.WriteLine($"Can't delete. Such employee: - {employee.Name} {employee.Surname} with experince {employee.Experience}, does not exist in firm.");
                return firm;
            }
            //firm.Employees.Remove(employee);
            firm.Employees.Remove(firm.Employees.Find(x => x.Name == employee.Name && x.Surname == employee.Surname));
            Console.WriteLine($"Employee excluded to firm successfully.");
            return firm;
        }

        public static bool IsExist(List<Employee> employees, Employee employee)
        {
            if (employees.FindIndex(x => x.Name == employee.Name && x.Surname == employee.Surname) != -1)
            {
                return true;
            }
            return false;
        }

    }
}
