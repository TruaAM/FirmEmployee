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

        public static Firm operator +(Firm firm, Employee employee)
        {
            if (IsExist(firm.Employees, employee))
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
            {
                Console.WriteLine($"Can't delete. Such employee: - {employee.Name} {employee.Surname} with experince {employee.Experience}, does not exist in firm.");
                return firm;
            }
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
